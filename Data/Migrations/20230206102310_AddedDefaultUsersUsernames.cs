using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1524-0256-4bb1-8d0f-6113224b44a9",
                column: "ConcurrencyStamp",
                value: "d7d84398-cb4f-4d0d-813d-4222b46ff188");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1535-0256-4cb0-8a5a-6113724b44a9",
                column: "ConcurrencyStamp",
                value: "d54eb4e4-be26-4d92-bb11-5f280b12b593");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd1234-6520-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b3859803-d655-4d27-a72c-72ac4050573b", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELzhkMLJLJH5NMPSAmnsPI9Z/DrxKTCtVVvEtZulb/RJF980+2b3L/nCLrk/FokcQQ==", "b6125942-bd5b-4937-b724-8c7f976fd92c", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd8765-6520-48ce-b45a-61a3724b44b9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6d670784-5509-4143-9adf-51f91faee128", true, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEL0PZN5q0TnqUuIyhth4hWfTPNsjB4ZwaUH93PBCpJZWkgBFFyBm0WEg7Y7SUfEo9g==", "1206e3ad-eb40-423e-ad14-7437eeea0afb", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1524-0256-4bb1-8d0f-6113224b44a9",
                column: "ConcurrencyStamp",
                value: "4a1a4d73-8f75-4a2e-861c-70526ccb2f25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1535-0256-4cb0-8a5a-6113724b44a9",
                column: "ConcurrencyStamp",
                value: "a85cff26-5589-454e-b787-24322f5071e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd1234-6520-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fe80bab8-5bdb-4e1c-b786-3e9aac504bd8", false, null, "AQAAAAEAACcQAAAAEM8FSOS1YruGdyFGj8Rpz05e0gbY91DC80NjTL2TdRDjQqA2LuxCsPvYnjS4D9xqMg==", "2d5e940e-92ff-4816-8c60-27e25376fb5e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd8765-6520-48ce-b45a-61a3724b44b9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "12e48a02-c9cc-413f-9619-2cceeca4e07e", false, "User@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEOOuVsnOh8Tqp2HkD9REhMXsi7kUY/evCWnl1VXAI1QGHarKenhaPRdrXrQV6mT+aA==", "929eaf0c-f0e0-4a3d-a067-198ddc5b5a09", null });
        }
    }
}
