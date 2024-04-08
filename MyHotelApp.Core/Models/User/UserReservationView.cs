using MyHotelApp.Core.Models.Room;

namespace MyHotelApp.Core.Models.User
{
    public class UserReservationView
    {
        public int Id { get; set; }

        public RoomViewModel Room { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime LeaveDate { get; set; }

        public string UserId { get; set; } = null!;

        public bool IsApproved { get; set; }

        public string UserName { get; set; } = string.Empty;
    }
}
