using MyHotelApp.Core.Models.Review;

namespace MyHotelApp.Core.Contracts
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewModel>> AllReviewsAsync();
        Task<IEnumerable<AdminReviewViewModel>> AdminAllReviewsAsync();
        Task<bool> CanUserWriteReviewAsync(string userId);

        Task AddReviewAsync(AddReviewViewModel model, string userId);

        Task<bool> IsThereReviewAsync(int id);

        Task ReviewedReviewAsync(int id);

        Task<ReviewModel?> GetReviewByIdAsync(int id);

        Task DeleteReviewAsync(int id);

        Task<int> GetReviewToReviewedAsync();
    }
}
