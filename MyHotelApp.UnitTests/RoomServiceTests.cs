using Microsoft.EntityFrameworkCore;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Services;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.UnitTests
{
    public class RoomServiceTests
    {
        private IRoomService service;
        private ApplicationDbContext applicationDbContext;
        private Repository repository;

        [SetUp]
        public void Setup()
        {
            var contextOption = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("HotelDb")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOption);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();

            repository = new Repository(applicationDbContext);
            service = new RoomService(repository);
        }

        [Test]
        public async Task BookRoomTest() 
        {
            var reservationsBefore = await repository
                .AllReadOnly<ReservationRoom>()
                .ToArrayAsync();

            int roomId = 18;
            string startDate = "2024-06-01";
            string leaveDate = "2024-06-02";
            string userId = "561b31e2-573b-47ac-bfb9-1ec04eca1911";


            await service.BookRoom(roomId, startDate, leaveDate, userId);

            var reservationsAfter = await repository
                .AllReadOnly<ReservationRoom>()
                .ToArrayAsync();

            Assert.That(reservationsBefore, Has.Length.EqualTo(reservationsAfter.Length - 1));

            var reservation = reservationsAfter.Last();

            Assert.Multiple(() => 
            {
                Assert.That(reservation.UserId,Is.EqualTo(userId));
                Assert.That(reservation.RoomId,Is.EqualTo(roomId));
                Assert.That(reservation.CheckInDate,Is.EqualTo(DateTime.Parse(startDate)));
                Assert.That(reservation.CheckOutDate,Is.EqualTo(DateTime.Parse(leaveDate)));
            });

            var expectedBadResult = await service.BookRoom(roomId, startDate, leaveDate, userId);

            Assert.That(expectedBadResult, Is.EqualTo(0));
        }

        [Test]
        public async Task GetRoomTypeCategoriesTest() 
        {
            var roomCategories = await service.GetRoomTypeCategories();

            Assert.Multiple(() => 
            {
                Assert.That(roomCategories.Count(),Is.EqualTo(3));
                Assert.That(roomCategories.FirstOrDefault(c => c.Id == 1)!.Name, Is.EqualTo("Double"));
                Assert.That(roomCategories.FirstOrDefault(c => c.Id == 2)!.Name, Is.EqualTo("Studio"));
                Assert.That(roomCategories.FirstOrDefault(c => c.Id == 3)!.Name, Is.EqualTo("Apartment"));
            });
        }

        [Test]
        public async Task GetViewCategoriesTest() 
        {
            var viewTypes = await service.GetViewCategories();

            Assert.Multiple(() =>
            {
                Assert.That(viewTypes.Count(), Is.EqualTo(2));
                Assert.That(viewTypes.FirstOrDefault(c => c.Id == 1)!.Name, Is.EqualTo("Sea View"));
                Assert.That(viewTypes.FirstOrDefault(c => c.Id == 2)!.Name, Is.EqualTo("Park View"));
            });
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }

    }
}