using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d2c465c4-7414-43db-931e-fba9a322125b", 0, "50fa1879-1b0f-4cd8-8bb0-85e262cd5eed", "admin@mail.com", false, false, null, "AMIN@MAIL.COM", "AMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBvze/YmjrA0D8hRwd+WP+irUk5H1lB7n/DKNwWOr4x89qXbBhXgSUTVDwO7eYDaFg==", null, false, "7e05ef5e-13c7-4ac8-9263-eef0ac657285", false, "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b");
        }
    }
}
