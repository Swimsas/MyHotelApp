using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class FixTextUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "71c573dc-fbab-4e63-842b-22f6214a05b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14c0d211-8033-4592-b98a-dad3c969c2e0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9203a92d-c02b-41d1-b87b-d34b279ed5c0", "833c4610-6732-4059-acaf-f9e06de0e06d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0ad926a-ddc5-4480-b96b-45724f15f6f1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "24703ddc-e702-4393-820e-9a32ed57ca40", "TEST@ABV.BG", "TEST@ABV.BG", "b2134890-6644-4e2e-ace5-979c46bb6be4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0577b40-533a-4a81-9086-5ff4b745bd73", "AQAAAAEAACcQAAAAEAx7wR4U5x5HHR62W6lKNP4H5dSo9eUTHcJeJbO49Hk7QG6j6+Q15oLy6jSoY9bARA==", "3cea12b7-eada-471a-9e6f-a435ed8ef62a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "c0ad926a-ddc5-4480-b96b-45724f15f6f1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "7259f913-7861-4a09-89c2-ce4c4a2e3861", "test@abv.bg", "test@abv.bg", "cb22015a-b6e7-4c3b-af1e-8ba18bba5beb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dd2217e-6bee-47a3-9012-7f5353698a90", "AQAAAAEAACcQAAAAEDz2qnq4LsFy4KTNrWL2Mk4qsn1udEadU4XdehojxKse6WiOZ2hDzO8AYc2oDX/BpQ==", "60196dea-137c-4fc5-b6e6-473e05925476" });
        }
    }
}
