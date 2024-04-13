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
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM"
            };

            var user = new IdentityUser()
            {
                Id = "14c0d211-8033-4592-b98a-dad3c969c2e0",
                UserName = "sa6a@mail.bg",
                NormalizedUserName = "SA6A@MAIL.BG",
                Email = "sa6a@mail.bg",
                NormalizedEmail = "SA6A@MAIL.BG"
            };

            var user1 = new IdentityUser()
            {
                Id = "c0ad926a-ddc5-4480-b96b-45724f15f6f1",
                UserName = "test@abv.bg",
                NormalizedUserName = "TEST@ABV.BG",
                Email = "test@abv.bg",
                NormalizedEmail = "TEST@ABV.BG"
            };

            admin.PasswordHash = hasher.HashPassword(admin,"123456");
            user.PasswordHash = "AQAAAAEAACcQAAAAECacEJr212soez+07REkpk1pEDKRZVLgB1BN/uNFuns52wXtnYFZMgMrFydGDdogWw==";
            user1.PasswordHash = "AQAAAAEAACcQAAAAEPa42oB5ebIN9P7sDxOtZ/d7J0DM6vZ0RXB4dqHs5t9o1v2GEgPvHvniWzHOb6gjFQ==";

            builder.HasData(admin,user,user1);
       } 
    }
}
