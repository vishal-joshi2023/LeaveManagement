using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddPeriodAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cca1535-0256-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "6dde15db-7870-46af-b871-9a704e0c70c0", "administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a45d23bc-0256-4bb1-8d0f-6113224b44a9",
                column: "ConcurrencyStamp",
                value: "7b452f6b-4e1f-4316-ac75-ebedf131161b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbcd8765-6520-48ce-b45a-61a3724b44b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140afbed-e38d-441b-b168-4504300207ee", "AQAAAAEAACcQAAAAEKPVF+k2Zkt9xROGKZGpWPA1WoREdYrN+3Zmr4l6Ds4BB+oTbauCMCRbEC558weejA==", "78e269a0-89ef-4af5-a316-3e2d6b5a41b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cccd1234-6520-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b9b427f-5225-4950-ad7b-ea08d90f84eb", "AQAAAAEAACcQAAAAENBKgRzSQFv3+o2SJ8/FpCq+7z/cgGR4TSZB2e+7RwuzdTaX11EhK93FYGasIDOFfg==", "72af8d06-312c-4918-9701-9837949945b3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cca1535-0256-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "cc52eb97-4eba-492b-9a76-3b96b96f3276", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a45d23bc-0256-4bb1-8d0f-6113224b44a9",
                column: "ConcurrencyStamp",
                value: "3e23d69b-b058-4a5b-bc94-f37236d61226");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbcd8765-6520-48ce-b45a-61a3724b44b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed758a12-dd1c-4f92-b22e-29865a0004df", "AQAAAAEAACcQAAAAEGKK0HuJONZSfeTTSSnaqp9+Ih3I/UkcRPk6hv70ni7w3g6aXH4wN+C6wFIndfyi3w==", "6d5480ea-c0e4-4f76-880b-673f050cef23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cccd1234-6520-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0aa485-4f4b-4668-b997-08c95d28d587", "AQAAAAEAACcQAAAAEIcaIQXTNdJA7w3vKczeIO1KB98tfwVvzKvRT3DGkgADeAC+J/SFIilGTWpdF6sf8w==", "90ce1c07-c54b-47ed-9112-6f197529aa2c" });
        }
    }
}
