using Microsoft.EntityFrameworkCore;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Review;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository repository;
        public ReviewService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddReviewAsync(AddReviewViewModel model,string userId)
        {
            var review = new Review() 
            {
                Name = model.Name,
                Description = model.Description,
                IdReviewer = userId,
                Rating = model.Rating
            };

            await repository.AddAsync(review);
            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<AdminReviewViewModel>> AdminAllReviewsAsync()
        {
            var model = await repository.AllReadOnly<Review>()
                .Select(r => new AdminReviewViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description,
                    Rating = r.Rating,
                    IsReviewed = r.IsReviewed
                })
                .ToListAsync();

            return model;
        }

        public async Task<IEnumerable<ReviewModel>> AllReviewsAsync()
        {
            var reviews =await repository.AllReadOnly<Review>()
                .OrderByDescending(r => r.Id)
                .Select(r => new ReviewModel 
                {
                    Name = r.Name,
                    Description = r.Description,
                    Rating  = r.Rating
                })
                .ToListAsync();

            return reviews;
        }

        public async Task<bool> CanUserWriteReviewAsync(string userId)
        {
            var reservation = await repository
                .AllReadOnly<ReservationRoom>()
                .Where(r => r.UserId == userId && r.CheckInDate.Date < DateTime.Now.Date)
                .FirstOrDefaultAsync();

            var review = await repository
                .AllReadOnly<Review>()
                .FirstOrDefaultAsync(r => r.IdReviewer == userId);

            if (reservation != null && review == null) 
            {
                return true;
            }

            return false;
        }

        public async Task DeleteReviewAsync(int id)
        {
            await repository.DeleteAsync<Review>(id);
            await repository.SaveChangesAsync();
        }

        public async Task<ReviewModel?> GetReviewByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync<Review>(id);

            if (entity == null) 
            {
                return null;
            }

            var model = new ReviewModel()
            {
                Id = id,
                Name = entity.Name,
                Description = entity.Description,
                Rating = entity.Rating
            };

            return model;
        }

        public async Task<bool> IsThereReviewAsync(int id)
        {
            var review = await repository.GetByIdAsync<Review>(id);

            if (review == null) 
            {
                return false;
            }

            return true;
        }

        public async Task ReviewedReviewAsync(int id)
        {
            var review = await repository.GetByIdAsync<Review>(id);

            review!.IsReviewed = true;

            await repository.SaveChangesAsync();
        }
    }
}
