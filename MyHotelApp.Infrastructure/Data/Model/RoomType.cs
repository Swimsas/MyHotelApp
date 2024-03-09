using System.ComponentModel.DataAnnotations;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class RoomType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.RoomTypeNameMaxLength)]
        public string Name { get; set; } = string.Empty;
    }
}