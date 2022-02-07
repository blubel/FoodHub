using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class addedOrderController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "15454c46-99d1-4d59-9eca-62de002a0b85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "db5e763e-ab7d-409a-8106-4a8d0c4f7a8e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4edc85af-6c53-47ad-a266-474886648aa0", "AQAAAAEAACcQAAAAEB76zTn9XyNYrPzLg11XObRd9BhxoJJpUzVWzZV5EZh5xhqTDK56goZ6uJCU44IcWg==", "c2c0c46e-aefd-4745-8ede-69cbfd03351a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "c0ead00d-d368-423b-a34c-6e8eb161975e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "6b7e2495-7eb5-4ce9-aad6-c7088ae0286e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dbe2a48-5ce8-4d52-8512-e5b7dfdffa28", "AQAAAAEAACcQAAAAEJUMr19t+05hPXdrk1ubZSjje4Qkzf0e8ypFW6Gqht7dkBTS8kPJS/g7cOLlR/KF7g==", "46d828e5-4e2a-4837-a853-ae0076c0971f" });
        }
    }
}
