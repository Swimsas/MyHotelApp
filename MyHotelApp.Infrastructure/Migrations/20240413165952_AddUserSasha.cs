using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class AddUserSasha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4d673b49-1984-4663-8956-c3cadf4e6122");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "328356ac-1a26-4522-9739-e007bb59cfcf", "AQAAAAEAACcQAAAAEIeT5lzLWkW1zDdIjVVxAQbB74PkkZ3kk+yDg1W0wn5b6cuHtschMrlCgbbG22Pk8g==", "3dc25626-c4c4-4994-bb40-8d0a897f9c5c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "14c0d211-8033-4592-b98a-dad3c969c2e0", 0, "91e80085-1497-4090-b191-39ea4e1afba7", "sa6a@mail.bg", false, false, null, "SA6A@MAIL.BG", "SA6A@MAIL.BG", "AQAAAAEAACcQAAAAECacEJr212soez+07REkpk1pEDKRZVLgB1BN/uNFuns52wXtnYFZMgMrFydGDdogWw==", null, false, "f15e978e-9aea-45ef-a222-32ff1d2b5d94", false, "sa6a@mail.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14c0d211-8033-4592-b98a-dad3c969c2e0");

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
    }
}
