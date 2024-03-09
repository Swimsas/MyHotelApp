using System.ComponentModel.DataAnnotations;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class ViewType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.ViewTypeNameMaxLength)]
        public string Name { get; set; } = string.Empty;
    }
}