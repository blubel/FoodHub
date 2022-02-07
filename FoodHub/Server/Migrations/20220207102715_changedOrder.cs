using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class changedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customs_CustomId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomPrice",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CustomId",
                table: "Orders",
                newName: "IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomId",
                table: "Orders",
                newName: "IX_Orders_IngredientId");

            migrationBuilder.AddColumn<int>(
                name: "DrinkId",
                table: "Orders",
                type: "int",
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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DrinkId",
                table: "Orders",
                column: "DrinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drink_DrinkId",
                table: "Orders",
                column: "DrinkId",
                principalTable: "Drink",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Ingredient_IngredientId",
                table: "Orders",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drink_DrinkId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Ingredient_IngredientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DrinkId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "Orders",
                newName: "CustomId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_IngredientId",
                table: "Orders",
                newName: "IX_Orders_CustomId");

            migrationBuilder.AddColumn<double>(
                name: "CustomPrice",
                table: "Orders",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "8a09f394-d17b-43c1-ba31-95378ef91453");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "8c9307da-ac80-4cf3-9208-5bf107b8e947");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b03485bb-c0e6-412d-bdbd-e89c60c31b69", "AQAAAAEAACcQAAAAEJJnMQddFhtNcRv+TStlXnpSukhN4BK5DG1GUlecQpP4IX9vR0Nso9me7GbloY5KYw==", "82e206a9-68a0-420f-8554-dd278b811a94" });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customs_CustomId",
                table: "Orders",
                column: "CustomId",
                principalTable: "Customs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
