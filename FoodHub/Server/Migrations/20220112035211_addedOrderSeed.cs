using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class addedOrderSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "fdcbd6f6-7b25-4365-bf29-5eb77306c49c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "68838213-93df-4934-9ff7-040bcaf7fb11");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e99d8398-18db-4171-b7bc-568ca3dc7b6b", "AQAAAAEAACcQAAAAEH1RWi3lvm/oSwdNwbrhBTXyv+YGcyerdUKEQNl0wz6oJ8xeEYWDjr95dp+bnru3nw==", "8e43a591-66e3-4e88-8558-aeffc2ff6f7b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
