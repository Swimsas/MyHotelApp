using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class ViewType
    {
        [Key]
        [Comment("RoomView Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.ViewTypeNameMaxLength)]
        [Comment("RoomViwe Name")]
        public string Name { get; set; } = string.Empty;
    }
}