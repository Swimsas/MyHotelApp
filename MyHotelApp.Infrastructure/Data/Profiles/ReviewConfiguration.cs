using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1,
                    Name = "Sarah Johnson",
                    Description = "Fantastic experience! Cozy ambiance, impeccable service, divine food.",
                    Rating = 5
                },
                new Review
                {
                    Id = 2,
                    Name = "Michael Smith",
                    Description = "Disappointing experience. Overwhelmed staff, mediocre food.",
                    Rating = 2
                },
                new Review
                {
                    Id = 3,
                    Name = "Emily Brown",
                    Description = "Hidden gem! Lively atmosphere, friendly staff, top-notch cocktails.",
                    Rating = 4
                },
                new Review
                {
                    Id = 4,
                    Name = "David Miller",
                    Description = "Decent place with average food. Nothing stood out.",
                    Rating = 3
                },
                new Review
                {
                    Id = 5,
                    Name = "Sophia Garcia",
                    Description = "Overpriced. Small portions, unimpressive flavors.",
                    Rating = 2
                },
                new Review
                {
                    Id = 6,
                    Name = "John Doe",
                    Description = "Great location, friendly staff, cleanliness could be improved.",
                    Rating = 4
                },
                new Review
                {
                    Id = 7,
                    Name = "Alice Green",
                    Description = "Exceeded expectations! Beautiful rooms, excellent service, delicious breakfast.",
                    Rating = 5
                },
                new Review
                {
                    Id = 8,
                    Name = "Robert White",
                    Description = "Average experience. Decent room, disturbing noise.",
                    Rating = 3
                },
                new Review
                {
                    Id = 9,
                    Name = "Emma Taylor",
                    Description = "Lovely stay! Attentive staff, clean and comfortable room, breathtaking view.",
                    Rating = 5
                },
                new Review
                {
                    Id = 10,
                    Name = "William Clark",
                    Description = "Disappointed with rude service and misrepresented room.",
                    Rating = 1
                }
            );
        }
    }
}
