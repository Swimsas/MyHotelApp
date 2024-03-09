using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasData(
                new RoomType
                {
                    Id = 1,
                    Name = "Double"
                },
                 new RoomType
                 {
                     Id = 2,
                     Name = "Studio"
                 },
                  new RoomType
                  {
                      Id = 3,
                      Name = "Apartment"
                  }
                );
        }
    }

}

