using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotelApp.Infrastructure.Data.Model
{
    public class ReservationRoom
    {
        [Key]
        [Comment("ReservationRoom Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("User Id of reservation")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        [Comment("Room Id for reservation")]
        public int RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;

        [Required]
        [Comment("Date for check in")]
        public DateTime CheckInDate { get; set; }

        [Required]
        [Comment("Date for check out")]
        public DateTime CheckOutDate { get; set; }

        [Required]
        [Comment("Is or not approve from admin")]
        public bool IsApproved { get; set; } = false;
    }
}
