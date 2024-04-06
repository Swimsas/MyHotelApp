using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class AddReviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Fantastic experience! Cozy ambiance, impeccable service, divine food.", "Sarah Johnson", 5 },
                    { 2, "Disappointing experience. Overwhelmed staff, mediocre food.", "Michael Smith", 2 },
                    { 3, "Hidden gem! Lively atmosphere, friendly staff, top-notch cocktails.", "Emily Brown", 4 },
                    { 4, "Decent place with average food. Nothing stood out.", "David Miller", 3 },
                    { 5, "Overpriced. Small portions, unimpressive flavors.", "Sophia Garcia", 2 },
                    { 6, "Great location, friendly staff, cleanliness could be improved.", "John Doe", 4 },
                    { 7, "Exceeded expectations! Beautiful rooms, excellent service, delicious breakfast.", "Alice Green", 5 },
                    { 8, "Average experience. Decent room, disturbing noise.", "Robert White", 3 },
                    { 9, "Lovely stay! Attentive staff, clean and comfortable room, breathtaking view.", "Emma Taylor", 5 },
                    { 10, "Disappointed with rude service and misrepresented room.", "William Clark", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
