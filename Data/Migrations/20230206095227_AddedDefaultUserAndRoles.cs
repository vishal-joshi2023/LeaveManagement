using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ecd1524-0256-4bb1-8d0f-6113224b44a9", "4a1a4d73-8f75-4a2e-861c-70526ccb2f25", "User", "USER" },
                    { "5ecd1535-0256-4cb0-8a5a-6113724b44a9", "a85cff26-5589-454e-b787-24322f5071e4", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abcd1234-6520-4cb0-8a5a-6113724b44a9", 0, "fe80bab8-5bdb-4e1c-b786-3e9aac504bd8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEM8FSOS1YruGdyFGj8Rpz05e0gbY91DC80NjTL2TdRDjQqA2LuxCsPvYnjS4D9xqMg==", null, false, "2d5e940e-92ff-4816-8c60-27e25376fb5e", null, false, null },
                    { "abcd8765-6520-48ce-b45a-61a3724b44b9", 0, "12e48a02-c9cc-413f-9619-2cceeca4e07e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "User@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEOOuVsnOh8Tqp2HkD9REhMXsi7kUY/evCWnl1VXAI1QGHarKenhaPRdrXrQV6mT+aA==", null, false, "929eaf0c-f0e0-4a3d-a067-198ddc5b5a09", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ecd1535-0256-4cb0-8a5a-6113724b44a9", "abcd1234-6520-4cb0-8a5a-6113724b44a9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ecd1524-0256-4bb1-8d0f-6113224b44a9", "abcd8765-6520-48ce-b45a-61a3724b44b9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ecd1535-0256-4cb0-8a5a-6113724b44a9", "abcd1234-6520-4cb0-8a5a-6113724b44a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ecd1524-0256-4bb1-8d0f-6113224b44a9", "abcd8765-6520-48ce-b45a-61a3724b44b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1524-0256-4bb1-8d0f-6113224b44a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1535-0256-4cb0-8a5a-6113724b44a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd1234-6520-4cb0-8a5a-6113724b44a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd8765-6520-48ce-b45a-61a3724b44b9");
        }
    }
}
