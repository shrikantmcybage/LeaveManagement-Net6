using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d4881d6-b06e-44b5-978c-bfcc9fcfbf29", "317635f7-b73c-469c-be84-efc1f5c70ec4", "User", "USER" },
                    { "0f4881d6-a06e-44b5-978c-bfcc9fcfbf29", "acb60a17-5a86-4495-b952-c85702020ade", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29", 0, "8ce5d0c7-0bbc-446d-b054-5c4cab8b9106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@abc.com", false, "Admin", "Admin", false, null, "ADMIN@ABC.COM", null, "AQAAAAEAACcQAAAAEDw56EOVqjvtOWcptxV+9bY4WzOhUdUOH+n4iZz7SJHuhL4xC8aXkCYMyL5XrAUnVA==", null, false, "33b69cd5-a4f0-42ce-ae4e-677ee2801c8e", null, false, null },
                    { "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29", 0, "02498873-50f0-4a9b-ad99-30528ce525f4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@abc.com", false, "User", "UserLast", false, null, "USER@ABC.COM", null, "AQAAAAEAACcQAAAAEN9guzTmjK32TmMk3eojbVgsMCvQK85AdlFh9yjF1eBOkbHbl2nsJV28bOFkod7/+A==", null, false, "9233587a-35b6-47a8-bf3f-9d2d750ff3ee", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f4881d6-a06e-44b5-978c-bfcc9fcfbf29", "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0d4881d6-b06e-44b5-978c-bfcc9fcfbf29", "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f4881d6-a06e-44b5-978c-bfcc9fcfbf29", "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d4881d6-b06e-44b5-978c-bfcc9fcfbf29", "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d4881d6-b06e-44b5-978c-bfcc9fcfbf29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f4881d6-a06e-44b5-978c-bfcc9fcfbf29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29");
        }
    }
}
