using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class ViewTypeConfiguration : IEntityTypeConfiguration<ViewType>
    {
        public void Configure(EntityTypeBuilder<ViewType> builder)
        {
            builder.HasData(
                new ViewType()
                {
                    Id = 1,
                    Name = "Sea View"
                },
                  new ViewType()
                  {
                      Id = 2,
                      Name = "Park View"
                  }
                );
        }
    }
}
