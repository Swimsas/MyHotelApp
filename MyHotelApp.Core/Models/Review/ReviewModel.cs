

namespace MyHotelApp.Core.Models.Review
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Rating { get; set; }
    }
}
