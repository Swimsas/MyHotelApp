using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyHotelApp.Infrastructure.Data.Model;
using MyHotelApp.Infrastructure.Data.Profiles;

namespace MyHotelApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ViewTypeConfiguration());
            builder.ApplyConfiguration(new FloorConfiguration());
            builder.ApplyConfiguration(new RoomTypeConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<RoomType> RoomTypes  { get; set; } = null!;
        public DbSet<Floor> Floors   { get; set; } = null!;
        public DbSet<ViewType> ViewTypes { get; set; } = null!;
        public DbSet<ReservationRoom> ReservationRooms { get; set; } = null!;
        


    }
}
