using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class RoleUserConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> { RoleId = "1", UserId = "d2c465c4-7414-43db-931e-fba9a322125b" }
            );
        }
    }
}
