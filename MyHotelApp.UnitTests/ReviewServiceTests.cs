using Microsoft.EntityFrameworkCore;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Review;
using MyHotelApp.Core.Services;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data;
using MyHotelApp.Infrastructure.Data.Model;
using System.Security.AccessControl;

namespace MyHotelApp.UnitTests
{
    public class ReviewServiceTests
    {
        private IReviewService service;
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
            service = new ReviewService(repository);
        }

        [Test]
        public async Task AllReviewsAsyncTest()
        {
            var result = await service.AllReviewsAsync();

            Assert.That(result.Count,Is.EqualTo(10));
        }

        [Test]
        public async Task AddReviewAsyncTest()
        {
            int countOfReviewBeforAdding = (await service.AllReviewsAsync()).Count();
            
            var userId = "01bb4af1-84eb-47c5-8659-4c5655057d76";
            var name = "test testov";
            var description = "test test";
            var rating = 5;

            var reviewModel = new AddReviewViewModel()
            {
                Name = name,
                Description = description,
                Rating = rating
            };


            await service.AddReviewAsync(reviewModel, userId);

            int countOfReviewAfterAdding = (await service.AllReviewsAsync()).Count();
            
            Assert.That(countOfReviewAfterAdding, Is.EqualTo(countOfReviewBeforAdding + 1));
            
            var addedReview = await repository.AllReadOnly<Review>()
                .FirstOrDefaultAsync(r => r.IdReviewer == userId);
             
            Assert.That(addedReview, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(addedReview.Name, Is.EqualTo(name));
                Assert.That(addedReview.Description, Is.EqualTo(description));
                Assert.That(addedReview.Rating, Is.EqualTo(rating));
            });
        }

        [Test]
        public async Task AdminAllReviewsAsyncTest() 
        {
            var result = await service.AdminAllReviewsAsync();

            Assert.That(result.Count, Is.EqualTo(10));
        }

        [Test]
        public async Task CanUserWriteReviewAsyncTest() 
        {
            var userId = "c0ad926a-ddc5-4480-b96b-45724f15f6f1";

            var canUserWhritereview = await service.CanUserWriteReviewAsync(userId);

            Assert.That(canUserWhritereview, Is.True);

            var name = "test testov";
            var description = "test test";
            var rating = 5;

            var reviewModel = new AddReviewViewModel()
            {
                Name = name,
                Description = description,
                Rating = rating
            };

            await service.AddReviewAsync(reviewModel,userId);

            canUserWhritereview = await service.CanUserWriteReviewAsync(userId);

            Assert.That(canUserWhritereview, Is.False);
        }

        [Test]
        public async Task DeleteReviewAsyncTest() 
        {
            var allReviews = await service.AdminAllReviewsAsync();

            Assert.That(allReviews.Any(r => r.Id == 1), Is.True);

            await service.DeleteReviewAsync(1);

            allReviews = await service.AdminAllReviewsAsync();

            Assert.That(allReviews.Any(r => r.Id == 1), Is.False);
        }

        [Test]
        public async Task GetReviewByIdAsyncTest() 
        {
            int id = 1;
            
            var expectedResult = await service.GetReviewByIdAsync(id);
            var actualResult = await repository.GetByIdAsync<Review>(id);

            Assert.Multiple(() =>
            {
                Assert.That(expectedResult!.Name, Is.EqualTo(actualResult!.Name));
                Assert.That(expectedResult!.Description, Is.EqualTo(actualResult!.Description));
                Assert.That(expectedResult!.Rating, Is.EqualTo(actualResult!.Rating));

            });
        }

        [Test]
        public async Task GetReviewToReviewedAsyncTest() 
        {
            var result = await service.GetReviewToReviewedAsync();
            var actualResult = 10;
            Assert.That(result, Is.EqualTo(actualResult));
        }

        [Test]
        public void IsThereReviewAsyncTest()
        {
            Assert.Multiple(async () =>
            {
                Assert.That(await service.IsThereReviewAsync(1), Is.True);
                Assert.That(await service.IsThereReviewAsync(11), Is.False);
            });
        }

        [Test]
        public async Task ReviewedReviewAsyncTest() 
        {
            var review = await repository.GetByIdAsync<Review>(1);

            Assert.That(review!.IsReviewed, Is.False);

            await service.ReviewedReviewAsync(1);

            Assert.That(review!.IsReviewed, Is.True);
        }

        [TearDown]
        public void TearDown() 
        {
            applicationDbContext.Dispose();
        }

    }
}