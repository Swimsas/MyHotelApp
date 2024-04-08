using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class AddIsApprovedColToReservationRoomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "ReservationRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ceb68db3-15a8-41ef-b6d7-5a47d9c88823");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3002203c-5af4-4474-82eb-f18a4ab5e520", "AQAAAAEAACcQAAAAEPFh+5SFne5g2JHxAy8QmXyDg8ganiye8kY1O7vVeBOmdwjdQ6p3/nJn4UJrSWUVZQ==", "11f42197-6c1a-4ef1-852a-4084ca758032" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "ReservationRooms");

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
    }
}
