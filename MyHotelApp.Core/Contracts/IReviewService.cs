using MyHotelApp.Core.Models.Review;

namespace MyHotelApp.Core.Contracts
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewModel>> AllReviewsAsync();

        Task<bool> CanUserWriteReviewAsync(string userId);

        Task AddReviewAsync(AddReviewViewModel model, string userId);
    }
}
