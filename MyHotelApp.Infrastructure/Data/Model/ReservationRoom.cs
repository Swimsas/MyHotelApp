using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class ReservationRoom
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        public int RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}
