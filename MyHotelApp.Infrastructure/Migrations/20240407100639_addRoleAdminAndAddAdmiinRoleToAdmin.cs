using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class AddRoleAdminAndAddAdmiinRoleToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "67d0d374-06f9-41bd-8005-7b8d11d13919", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c595a4f-76ec-46a7-876a-6dd5eb4810ea", "AQAAAAEAACcQAAAAEB3zKPY/L9v5Qahg/RcXALbwMdC0PbnkRjpkaznftxb5OQA9p0DwxNh8WrGTsjB/ng==", "333cb4ea-1316-4709-8c54-41e1708593f8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "d2c465c4-7414-43db-931e-fba9a322125b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "d2c465c4-7414-43db-931e-fba9a322125b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50fa1879-1b0f-4cd8-8bb0-85e262cd5eed", "AQAAAAEAACcQAAAAEBvze/YmjrA0D8hRwd+WP+irUk5H1lB7n/DKNwWOr4x89qXbBhXgSUTVDwO7eYDaFg==", "7e05ef5e-13c7-4ac8-9263-eef0ac657285" });
        }
    }
}
