using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class Floor
    {
        [Key]
        [Comment("Floor Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.FloorNameMaxLength)]
        [Comment("Floor Name")]
        public string Name { get; set; } = string.Empty;
        
    }
}