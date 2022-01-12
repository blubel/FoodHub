using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class addedRestaurantItem1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "858b652e-4dae-4f92-a6f3-322d633d20d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "82afdfec-5ef8-4712-9547-220003fc6d02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "894bd7c7-6c98-4502-b216-cc386bf4b4ad", "AQAAAAEAACcQAAAAEE/LhG6VjDbxOc25x8vl1XUx96TknTndRylMEoL2admf6ExCGCjJX7Uov9WT3XeEkQ==", "8e157f42-dc2b-47c6-b834-e7e14357ce9e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2fd96ef8-6b04-4144-9658-fa4419633f91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "e75c4980-3983-4171-a149-302b45481b65");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e42cdeb-3cf1-4865-81f6-18e7d35e3789", "AQAAAAEAACcQAAAAEKVW1mw9eoOzwSSli7fkw/NjJWmOkci1B7ohkBMQyWrKuEzXVC1MLxTz+CySLdchHw==", "691d704a-02f3-4de3-972b-7ff80cf670a9" });
        }
    }
}
