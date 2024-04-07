using System.ComponentModel.DataAnnotations;
using static MyHotelApp.Infrastructure.Constants.DataConstants;
using static MyHotelApp.Core.Constants.ErrorMessages;

namespace MyHotelApp.Core.Models.Review
{
    public class AddReviewViewModel
    {
        [Required(ErrorMessage = RequiredField)]
        [StringLength(ReviewNameMaxLength,MinimumLength = ReviewNameMinLength, ErrorMessage = MinMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredField)]
        [StringLength(
            ReviewDescriptionMaxLength,
            MinimumLength = ReviewDescriptionMinLength,
            ErrorMessage = MinMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredField)]
        [Range(ReviewRatingMin,ReviewRatingMax,ErrorMessage = RangeNumbers)]
        public int Rating { get; set; }
    }
}
