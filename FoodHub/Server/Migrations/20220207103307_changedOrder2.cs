using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class changedOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealPrice",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SushiPrice",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Ingredient2Id",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ingredient3Id",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ingredient4Id",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ingredient5Id",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "a9551efc-90ed-4978-8d98-7e209e45f113");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "9928980a-e24f-4e55-92a6-ddf495d5e710");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0bdc0d-6eac-4ee4-81a5-5c4fc947e2cd", "AQAAAAEAACcQAAAAEB2j73hjVwcKZ1TlLLyGOlE+49jD/WBiAL2aRBwtPg5kPh4VqNbtFwlTprWOLQwkxg==", "d7522e37-10a4-4221-a778-2b50eefdff08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredient2Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Ingredient3Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Ingredient4Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Ingredient5Id",
                table: "Orders");

            migrationBuilder.AddColumn<double>(
                name: "MealPrice",
                table: "Orders",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SushiPrice",
                table: "Orders",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "f721c4c9-7ef7-4afb-804f-cfd6f3215908");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "7d33fe6e-758e-4b31-bbfe-8b7177e55426");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5434a860-2cac-499a-804d-ccdddfe53079", "AQAAAAEAACcQAAAAEMazbJg7njCNMsZCfqAEUyTBVqHxUDDnGeF7h6zHfwF+tIsG1QNApsmcGhGm4xao6Q==", "63217168-6779-4f83-a96e-5b56497a26b3" });
        }
    }
}
