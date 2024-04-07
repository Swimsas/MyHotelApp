namespace MyHotelApp.Core.Models.Review
{
    public class AdminReviewViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Rating { get; set; }
        public bool IsReviewed { get; set; }
    }
}
