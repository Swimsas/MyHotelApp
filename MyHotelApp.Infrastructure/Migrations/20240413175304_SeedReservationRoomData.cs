using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelApp.Infrastructure.Migrations
{
    public partial class SeedReservationRoomData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a84a1258-28a3-4778-9dde-4063708faf82");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14c0d211-8033-4592-b98a-dad3c969c2e0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dedc4dc0-5dcb-41f6-a4dc-cb9e72ddcf85", "eee2c86e-9a4f-475a-b9e1-e361071b6bf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0ad926a-ddc5-4480-b96b-45724f15f6f1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e967e237-fbc6-4bf1-81b2-7d2c209acebe", "92e3073d-d5b2-4738-9d4a-fd6d5a279658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b3fcbd9-0065-4be4-a153-e8e28a6d1afc", "AQAAAAEAACcQAAAAEG9jcp035VDAnv/p2KJTitCALlV8hGdc/pgy0cqFZ/cZruFCpf10+95cnL03wHcYYw==", "720f2ab9-5dda-421c-8041-6e9064aa07d5" });

            migrationBuilder.InsertData(
                table: "ReservationRooms",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "IsApproved", "RoomId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 33, "14c0d211-8033-4592-b98a-dad3c969c2e0" },
                    { 2, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 33, "14c0d211-8033-4592-b98a-dad3c969c2e0" },
                    { 3, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 33, "14c0d211-8033-4592-b98a-dad3c969c2e0" },
                    { 4, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 20, "c0ad926a-ddc5-4480-b96b-45724f15f6f1" },
                    { 5, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 21, "c0ad926a-ddc5-4480-b96b-45724f15f6f1" },
                    { 6, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 22, "c0ad926a-ddc5-4480-b96b-45724f15f6f1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationRooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationRooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationRooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationRooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationRooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReservationRooms",
                keyColumn: "Id",
                keyValue: 6);

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24703ddc-e702-4393-820e-9a32ed57ca40", "b2134890-6644-4e2e-ace5-979c46bb6be4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c465c4-7414-43db-931e-fba9a322125b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0577b40-533a-4a81-9086-5ff4b745bd73", "AQAAAAEAACcQAAAAEAx7wR4U5x5HHR62W6lKNP4H5dSo9eUTHcJeJbO49Hk7QG6j6+Q15oLy6jSoY9bARA==", "3cea12b7-eada-471a-9e6f-a435ed8ef62a" });
        }
    }
}
