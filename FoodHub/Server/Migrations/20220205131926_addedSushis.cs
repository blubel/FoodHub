using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class addedSushis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "Tuna Bowl", 7.2999999999999998 },
                    { 3, "Swordfish Bowl", 7.5 },
                    { 4, "Octopus Bowl", 8.0 },
                    { 5, "Oriental Bowl", 10.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2c8ac4eb-3520-4126-97b9-0ea52b55379c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "3b3a2ee7-08e5-4f21-b28b-739cf88639ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2014a1-8d32-46f3-96a8-3c63177a1317", "AQAAAAEAACcQAAAAEMCRJK3gX0ktmZmCt6ioGnJI3tZkkNpvykBKyp9ya/sxxx683mbeyLENf5ocpPoRWg==", "ddbddd44-89eb-4d73-8afd-2b373e879288" });
        }
    }
}
