using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FloorId { get; set; }

        [ForeignKey(nameof(FloorId))]
        public Floor Floor { get; set; } = null!;

        [Required]
        public int RoomTypeId { get; set; }

        public RoomType RoomType { get; set; } = null!;

        [Required]
        public int ViewTypeId { get; set; }

        public ViewType ViewType { get; set; } = null!;

        [Required]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
