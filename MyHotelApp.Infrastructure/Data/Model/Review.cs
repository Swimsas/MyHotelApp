using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MyHotelApp.Infrastructure.Constants.DataConstants;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class Review
    {
        [Key]
        [Comment("Review Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(ReviewNameMaxLength)]
        [Comment("Name of reviewer")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(ReviewDescriptionMaxLength)]
        [Comment("Description of review")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Rating of review")]
        public int Rating { get; set; }

        [Required]
        [Comment("Id of reviewer")]
        public string IdReviewer { get; set; } = string.Empty;

        [Required]
        [Comment("Is or not reviewed from admin")]
        public bool IsReviewed { get; set; } = false;
    }
}
