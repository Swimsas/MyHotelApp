using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<RoomType> RoomTypes  { get; set; } = null!;
        public DbSet<Floor> Floors   { get; set; } = null!;
        public DbSet<ViewType> ViewTypes { get; set; } = null!;
        public DbSet<ReservationRoom> ReservationRooms { get; set; } = null!;
        


    }
}
