using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Data.Migrations
{
    public partial class AddedDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ContactNumber", "Email", "Name" },
                values: new object[] { 1, "69 Yishun Avenue 7", "81443543", "yasmintazi@icloud.com", "Bel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ContactNumber", "Email", "Name" },
                values: new object[] { 2, "78 Macpherson Street 71", "81763881", "mirzaepicftw@gmail.com", "Mirza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
