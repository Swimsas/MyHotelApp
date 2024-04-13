using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHotelApp.Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class ReservationRoomConfiguration : IEntityTypeConfiguration<ReservationRoom>
    {
        public void Configure(EntityTypeBuilder<ReservationRoom> builder)
        {
            builder.HasData(
                new ReservationRoom()
                {
                    Id = 1,
                    UserId = "14c0d211-8033-4592-b98a-dad3c969c2e0",
                    RoomId = 33,
                    CheckInDate = DateTime.Parse("2024-04-1"),
                    CheckOutDate = DateTime.Parse("2024-04-2"),
                    IsApproved = false
                },
                new ReservationRoom()
                {
                    Id = 2,
                    UserId = "14c0d211-8033-4592-b98a-dad3c969c2e0",
                    RoomId = 33,
                    CheckInDate = DateTime.Parse("2024-04-2"),
                    CheckOutDate = DateTime.Parse("2024-04-3"),
                    IsApproved = false
                },
                 new ReservationRoom()
                 {
                     Id = 3,
                     UserId = "14c0d211-8033-4592-b98a-dad3c969c2e0",
                     RoomId = 33,
                     CheckInDate = DateTime.Parse("2024-04-3"),
                     CheckOutDate = DateTime.Parse("2024-04-4"),
                     IsApproved = false
                 },
                  new ReservationRoom()
                  {
                      Id = 4,
                      UserId = "c0ad926a-ddc5-4480-b96b-45724f15f6f1",
                      RoomId = 20,
                      CheckInDate = DateTime.Parse("2024-04-1"),
                      CheckOutDate = DateTime.Parse("2024-04-2"),
                      IsApproved = false
                  }, 
                  new ReservationRoom()
                  {
                      Id = 5,
                      UserId = "c0ad926a-ddc5-4480-b96b-45724f15f6f1",
                      RoomId = 21,
                      CheckInDate = DateTime.Parse("2024-04-3"),
                      CheckOutDate = DateTime.Parse("2024-04-4"),
                      IsApproved = false
                  },
                    new ReservationRoom()
                    {
                        Id = 6,
                        UserId = "c0ad926a-ddc5-4480-b96b-45724f15f6f1",
                        RoomId = 22,
                        CheckInDate = DateTime.Parse("2024-04-4"),
                        CheckOutDate = DateTime.Parse("2024-04-5"),
                        IsApproved = false
                    }
                ); 
        }
    }
}
