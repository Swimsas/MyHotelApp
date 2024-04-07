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
    }
}
