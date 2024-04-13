using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class AddTestUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f1ba7e86-624e-4235-85f4-f952b7bccde8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14c0d211-8033-4592-b98a-dad3c969c2e0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ea2e97c-de18-485c-9582-53337c7e35dc", "0c4e167c-5a41-4bed-839c-078d5203ccac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dd2217e-6bee-47a3-9012-7f5353698a90", "AQAAAAEAACcQAAAAEDz2qnq4LsFy4KTNrWL2Mk4qsn1udEadU4XdehojxKse6WiOZ2hDzO8AYc2oDX/BpQ==", "60196dea-137c-4fc5-b6e6-473e05925476" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c0ad926a-ddc5-4480-b96b-45724f15f6f1", 0, "7259f913-7861-4a09-89c2-ce4c4a2e3861", "test@abv.bg", false, false, null, "test@abv.bg", "test@abv.bg", "AQAAAAEAACcQAAAAEPa42oB5ebIN9P7sDxOtZ/d7J0DM6vZ0RXB4dqHs5t9o1v2GEgPvHvniWzHOb6gjFQ==", null, false, "cb22015a-b6e7-4c3b-af1e-8ba18bba5beb", false, "test@abv.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0ad926a-ddc5-4480-b96b-45724f15f6f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4d673b49-1984-4663-8956-c3cadf4e6122");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14c0d211-8033-4592-b98a-dad3c969c2e0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91e80085-1497-4090-b191-39ea4e1afba7", "f15e978e-9aea-45ef-a222-32ff1d2b5d94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "328356ac-1a26-4522-9739-e007bb59cfcf", "AQAAAAEAACcQAAAAEIeT5lzLWkW1zDdIjVVxAQbB74PkkZ3kk+yDg1W0wn5b6cuHtschMrlCgbbG22Pk8g==", "3dc25626-c4c4-4994-bb40-8d0a897f9c5c" });
        }
    }
}
