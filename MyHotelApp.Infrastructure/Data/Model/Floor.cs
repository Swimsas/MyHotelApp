using System.ComponentModel.DataAnnotations;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class Floor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.FloorNameMaxLength)]
        public string Name { get; set; } = string.Empty;
        
    }
}