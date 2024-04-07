using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
       {
            var hasher = new PasswordHasher<IdentityUser>();

            var admin = new IdentityUser()
            {
                Id = "d2c465c4-7414-43db-931e-fba9a322125b",
                UserName = "admin@mail.com",
                NormalizedUserName = "AMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "AMIN@MAIL.COM"
            };
            
            admin.PasswordHash = hasher.HashPassword(admin,"123456");

            builder.HasData(admin);
       } 
    }
}
