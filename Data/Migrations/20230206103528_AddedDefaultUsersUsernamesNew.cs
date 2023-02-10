using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ecd1524-0256-4bb1-8d0f-6113224b44a9", "abcd8765-6520-48ce-b45a-61a3724b44b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1524-0256-4bb1-8d0f-6113224b44a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd8765-6520-48ce-b45a-61a3724b44b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1535-0256-4cb0-8a5a-6113724b44a9",
                column: "ConcurrencyStamp",
                value: "a90911c8-90f1-4013-82a3-d99c221890be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a45d23bc-0256-4bb1-8d0f-6113224b44a9", "4db6cddc-48d1-4af7-9c93-0fa5f9b0cc79", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd1234-6520-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f478819-ccc2-4a01-8a99-b6f4f035cb63", "AQAAAAEAACcQAAAAEPnA9kStjuMbKe4X7ilH7zqC+tjrQi7rlXn9etDSaBeuFhD7PMGcbFnxOxQzqPlg5Q==", "53d126fd-7ab2-4ed1-8771-a917c6cdb6e7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cbcd8765-6520-48ce-b45a-61a3724b44b9", 0, "4fd6368f-6347-4747-988c-4b1b34196368", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAELqz9osmUfpr7AtcypzGxBFOc1eFLazlC4pSUHtpm0eAcC9ODW/N6yr0jzHRJDFhNw==", null, false, "fb7fb094-2b68-4de4-9317-23ab773359a7", null, false, "user@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a45d23bc-0256-4bb1-8d0f-6113224b44a9", "cbcd8765-6520-48ce-b45a-61a3724b44b9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a45d23bc-0256-4bb1-8d0f-6113224b44a9", "cbcd8765-6520-48ce-b45a-61a3724b44b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a45d23bc-0256-4bb1-8d0f-6113224b44a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbcd8765-6520-48ce-b45a-61a3724b44b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ecd1535-0256-4cb0-8a5a-6113724b44a9",
                column: "ConcurrencyStamp",
                value: "d54eb4e4-be26-4d92-bb11-5f280b12b593");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ecd1524-0256-4bb1-8d0f-6113224b44a9", "d7d84398-cb4f-4d0d-813d-4222b46ff188", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcd1234-6520-4cb0-8a5a-6113724b44a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3859803-d655-4d27-a72c-72ac4050573b", "AQAAAAEAACcQAAAAELzhkMLJLJH5NMPSAmnsPI9Z/DrxKTCtVVvEtZulb/RJF980+2b3L/nCLrk/FokcQQ==", "b6125942-bd5b-4937-b724-8c7f976fd92c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abcd8765-6520-48ce-b45a-61a3724b44b9", 0, "6d670784-5509-4143-9adf-51f91faee128", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEL0PZN5q0TnqUuIyhth4hWfTPNsjB4ZwaUH93PBCpJZWkgBFFyBm0WEg7Y7SUfEo9g==", null, false, "1206e3ad-eb40-423e-ad14-7437eeea0afb", null, false, "user@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ecd1524-0256-4bb1-8d0f-6113224b44a9", "abcd8765-6520-48ce-b45a-61a3724b44b9" });
        }
    }
}
