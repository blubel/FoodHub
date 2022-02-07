using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodHub.Server.Migrations
{
    public partial class addedDrinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "af80e5f1-0515-4fde-9d78-52e34efb52c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "c86b9dee-0161-4860-a066-35ebd6d66d97");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec37c59a-3f3c-439f-9fa9-73317477e4cf", "AQAAAAEAACcQAAAAEGpuhcR4Jd4uTUTHDeaU9FYSacbMmJEGpfgWR39AfcVOcuyvYIIp4MPBFG6Cl814zQ==", "c8749fb7-63b4-4422-a81a-f7f34f26c131" });
        }
    }
}
