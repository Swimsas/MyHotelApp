using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class Room
    {
        [Key]
        [Comment("Room Identifier")]
        public int Id { get; set; }

        [MaxLength(Constants.DataConstants.ImgRoomMaxLength)]
        [Comment("Url for room image")]
        public string? ImgUrl { get; set; }

        [Required]
        [Comment("Floor Identifier")]
        public int FloorId { get; set; }

        [ForeignKey(nameof(FloorId))]
        public Floor Floor { get; set; } = null!;

        [Required]
        [Comment("RoomType Identifier")]
        public int RoomTypeId { get; set; }

        public RoomType RoomType { get; set; } = null!;

        [Required]
        [Comment("RoomView Identifier")]
        public int ViewTypeId { get; set; }

        public ViewType ViewType { get; set; } = null!;

        [Required]
        [Column(TypeName ="decimal(18,2)")]
        [Comment("Price of room")]
        public decimal Price { get; set; }
    }
}
