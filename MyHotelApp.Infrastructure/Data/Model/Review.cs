using System.ComponentModel.DataAnnotations;
using static MyHotelApp.Infrastructure.Constants.DataConstants;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(ReviewNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(ReviewDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Rating { get; set; }

        [Required]
        public string IdReviewer { get; set; } = string.Empty;
    }
}
