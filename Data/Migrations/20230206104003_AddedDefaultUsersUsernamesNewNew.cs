using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesNewNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ecd1535-0256-4cb0-8a5a-6113724b44a9", "abcd1234-6520-4cb0-8a5a-6113724b44a9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1535-0256-4cb0-8a5a-6113724b44a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd1234-6520-4cb0-8a5a-6113724b44a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a45d23bc-0256-4bb1-8d0f-6113224b44a9",
                column: "ConcurrencyStamp",
                value: "3e23d69b-b058-4a5b-bc94-f37236d61226");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cca1535-0256-4cb0-8a5a-6113724b44a9", "cc52eb97-4eba-492b-9a76-3b96b96f3276", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbcd8765-6520-48ce-b45a-61a3724b44b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed758a12-dd1c-4f92-b22e-29865a0004df", "AQAAAAEAACcQAAAAEGKK0HuJONZSfeTTSSnaqp9+Ih3I/UkcRPk6hv70ni7w3g6aXH4wN+C6wFIndfyi3w==", "6d5480ea-c0e4-4f76-880b-673f050cef23" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cccd1234-6520-4cb0-8a5a-6113724b44a9", 0, "0c0aa485-4f4b-4668-b997-08c95d28d587", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIcaIQXTNdJA7w3vKczeIO1KB98tfwVvzKvRT3DGkgADeAC+J/SFIilGTWpdF6sf8w==", null, false, "90ce1c07-c54b-47ed-9112-6f197529aa2c", null, false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5cca1535-0256-4cb0-8a5a-6113724b44a9", "cccd1234-6520-4cb0-8a5a-6113724b44a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cca1535-0256-4cb0-8a5a-6113724b44a9", "cccd1234-6520-4cb0-8a5a-6113724b44a9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cca1535-0256-4cb0-8a5a-6113724b44a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cccd1234-6520-4cb0-8a5a-6113724b44a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a45d23bc-0256-4bb1-8d0f-6113224b44a9",
                column: "ConcurrencyStamp",
                value: "4db6cddc-48d1-4af7-9c93-0fa5f9b0cc79");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ecd1535-0256-4cb0-8a5a-6113724b44a9", "a90911c8-90f1-4013-82a3-d99c221890be", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbcd8765-6520-48ce-b45a-61a3724b44b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fd6368f-6347-4747-988c-4b1b34196368", "AQAAAAEAACcQAAAAELqz9osmUfpr7AtcypzGxBFOc1eFLazlC4pSUHtpm0eAcC9ODW/N6yr0jzHRJDFhNw==", "fb7fb094-2b68-4de4-9317-23ab773359a7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abcd1234-6520-4cb0-8a5a-6113724b44a9", 0, "4f478819-ccc2-4a01-8a99-b6f4f035cb63", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPnA9kStjuMbKe4X7ilH7zqC+tjrQi7rlXn9etDSaBeuFhD7PMGcbFnxOxQzqPlg5Q==", null, false, "53d126fd-7ab2-4ed1-8771-a917c6cdb6e7", null, false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ecd1535-0256-4cb0-8a5a-6113724b44a9", "abcd1234-6520-4cb0-8a5a-6113724b44a9" });
        }
    }
}
