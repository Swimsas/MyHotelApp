using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class RoomType
    {
        [Key]
        [Comment("RoomType Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.RoomTypeNameMaxLength)]
        [Comment("RoomType Name")]
        public string Name { get; set; } = string.Empty;
    }
}