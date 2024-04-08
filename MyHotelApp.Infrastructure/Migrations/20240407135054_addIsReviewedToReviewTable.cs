using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class AddIsReviewedToReviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReviewed",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "98c87ce6-f232-43eb-8074-d79a9b7ef38a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ef4f0ac-40b7-4050-b1b3-60f57b8ccde5", "AQAAAAEAACcQAAAAEKnujVc0oc8OSkueQQDzk82fu6XkDQsoNwQNxz3abCz1vVyfWtpMUhiYpdrFzAqHMQ==", "b2040978-65f7-4074-a4bd-bc6a455134df" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReviewed",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "73f338c4-52c9-4655-a624-9e49e4b718ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f073262a-5b21-43a6-a050-217563913b33", "AQAAAAEAACcQAAAAEH3fK2WlsycBc+gSrgzmbUEts/lsGjAxuFKATJYXym7ODe9G8gOCA+TUUKR/9xGyfg==", "b907dfcf-545a-4c5a-a7ba-3d3d415b7462" });
        }
    }
}
