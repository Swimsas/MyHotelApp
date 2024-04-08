using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class FixAdminNormalizedMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f073262a-5b21-43a6-a050-217563913b33", "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEH3fK2WlsycBc+gSrgzmbUEts/lsGjAxuFKATJYXym7ODe9G8gOCA+TUUKR/9xGyfg==", "b907dfcf-545a-4c5a-a7ba-3d3d415b7462" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "67d0d374-06f9-41bd-8005-7b8d11d13919");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c595a4f-76ec-46a7-876a-6dd5eb4810ea", "AMIN@MAIL.COM", "AMIN@MAIL.COM", "AQAAAAEAACcQAAAAEB3zKPY/L9v5Qahg/RcXALbwMdC0PbnkRjpkaznftxb5OQA9p0DwxNh8WrGTsjB/ng==", "333cb4ea-1316-4709-8c54-41e1708593f8" });
        }
    }
}
