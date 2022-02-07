using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class addedDrinks2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "bea59e90-351a-4105-84b4-96e94ae796ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "d61f4d86-927a-4134-814f-5e607f33eabc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "560f4a0a-6b1b-4ead-8327-8a157a7f3112", "AQAAAAEAACcQAAAAECIUSugzmlqc8ldrG2rkQ+p2WWK+qo/RmQidZWExsBkGHT/x1chb4qq9AbEyQCciJA==", "7e97fe78-71e2-4101-8cdf-e0aff5f0f2f1" });
        }
    }
}
