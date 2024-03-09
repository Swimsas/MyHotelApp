using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room
                {
                    Id = 1,
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 2,
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 3,
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 4,
                    FloorId = 1,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 5,
                    FloorId = 1,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 6,
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 7,
                    FloorId = 1,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 8,
                    FloorId = 1,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 9,
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 10,
                    FloorId = 1,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 11,
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 12,
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 13,
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 14,
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 15,
                    FloorId = 2,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 16,
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 17,
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 18,
                    FloorId = 2,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 19,
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 20,
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 21,
                    FloorId = 2,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 22,
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 23,
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 24,
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 25,
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 26,
                    FloorId = 3,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 27,
                    FloorId = 3,
                    RoomTypeId = 3,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 28,
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 29,
                    FloorId = 3,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 30,
                    FloorId = 3,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 31,
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 32,
                    FloorId = 3,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 33,
                    FloorId = 3,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                }, new Room
                {
                    Id = 34,
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 35,
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 36,
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 37,
                    FloorId = 4,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 38,
                    FloorId = 4,
                    RoomTypeId = 3,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 39,
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 40,
                    FloorId = 4,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 41,
                    FloorId = 4,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 42,
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 43,
                    FloorId = 4,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 44,
                    FloorId = 4,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                }
                );
        }
    }
}
