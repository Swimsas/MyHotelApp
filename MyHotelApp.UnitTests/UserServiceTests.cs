using Microsoft.EntityFrameworkCore;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Services;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.UnitTests
{
    public class UserServiceTests
    {
        private IUserService service;
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
            service = new UserService(repository);
        }

        [Test]
        public async Task GetReseravationByIdAsyncTest() 
        {
            var expectedReservation = await service.GetReseravationByIdAsync(1);

            var actualReservation = await repository.GetByIdAsync<ReservationRoom>(1);

            Assert.Multiple(() => 
            {
                Assert.That(expectedReservation!.Id,Is.EqualTo(actualReservation!.Id));
                Assert.That(expectedReservation!.StartDate,Is.EqualTo(actualReservation!.CheckInDate));
                Assert.That(expectedReservation!.LeaveDate,Is.EqualTo(actualReservation!.CheckOutDate));
                Assert.That(expectedReservation!.UserId,Is.EqualTo(actualReservation!.UserId));
                Assert.That(expectedReservation!.IsApproved,Is.EqualTo(actualReservation!.IsApproved));
            });
        }

        [Test]
        public async Task GetUserReservationAsyncTest() 
        {
            var userId = "14c0d211-8033-4592-b98a-dad3c969c2e0";

            var userReservations = await service.GetUserReservationAsync(userId);

            var actualUserReservations = await repository.AllReadOnly<ReservationRoom>()
                .Where(r => r.UserId == userId)
                .ToListAsync();

            Assert.That(userReservations.Count, Is.EqualTo(actualUserReservations.Count));
        }

        [Test]
        public async Task DeleteReservationTest() 
        {
            var allReservationBeforeDelete = await repository
                .AllReadOnly<ReservationRoom>()
                .ToArrayAsync();

            int idOfReservation = 1;

            await service.DeleteReservation(idOfReservation);

            var allReservationAfterDelete = await repository
                .AllReadOnly<ReservationRoom>()
                .ToArrayAsync();

            Assert.That(allReservationAfterDelete, Has.Length.EqualTo(allReservationBeforeDelete.Length - 1));

        }

        [Test]
        public async Task AllReservationsAsyncTest()
        {
            var allReservationsExpect = await  repository
                .AllReadOnly<ReservationRoom>()
                .ToArrayAsync();

            var allReservationActual = await service.AllReservationsAsync();

            Assert.That(allReservationsExpect, Has.Length.EqualTo(allReservationActual.Count()));
        }

        [Test]
        public async Task GetCountOfReservationsForApproveAsyncTest() 
        {
            var actualResult = await service.GetCountOfReservationsForApproveAsync();

            var expectedResult = await repository.AllReadOnly<ReservationRoom>()
                .Where(r => r.IsApproved == false)
                .ToArrayAsync();

            Assert.That(expectedResult, Has.Length.EqualTo(actualResult));
        }

        [Test]
        public async Task ApproveReservationAsyncTest()
        {
            var reservasionId = 1;

            var reservation = await repository.GetByIdAsync<ReservationRoom>(reservasionId);

            Assert.That(reservation!.IsApproved, Is.False);

            await service.ApproveReservationAsync(reservasionId);

            Assert.That(reservation!.IsApproved, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }

    }
}