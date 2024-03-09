using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class FloorConfiguration : IEntityTypeConfiguration<Floor>
    {
        public void Configure(EntityTypeBuilder<Floor> builder)
        {
            builder.HasData(
                new Floor
                {
                    Id = 1,
                    Name = "First"
                },
                 new Floor
                 {
                     Id = 2,
                     Name = "Second"
                 },
                  new Floor
                  {
                      Id = 3,
                      Name = "Third"
                  },
                   new Floor
                   {
                       Id = 4,
                       Name = "Fourth"
                   }
                );
        }
    }
}
