using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersandUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d4881d6-b06e-44b5-978c-bfcc9fcfbf29",
                column: "ConcurrencyStamp",
                value: "c3beb5f9-d24e-45e8-970f-3e7f5334bdc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f4881d6-a06e-44b5-978c-bfcc9fcfbf29",
                column: "ConcurrencyStamp",
                value: "bd22c1cc-a426-4230-8c16-06298e975651");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2b19cdae-b9b4-45db-baf8-c27c22b8c5dd", true, "ADMIN@ABC.COM", "AQAAAAEAACcQAAAAEFZ7E36OSkT6TMAIM7GVDcyPn1UKKinOYcpeYYAbyzKiba60Vm5KSN9V19uE3gnNIg==", "d1bbfddb-bcb0-4555-86d6-70dbe5a64ab8", "admin@abc.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "233d87c0-4610-431e-ba1d-6daad2ff6d5a", true, "USER@ABC.COM", "AQAAAAEAACcQAAAAEP6HhL1DhtX4y+8OFcl1lG/tYciSyXZirCudPXU3hnkbqsNb8q+Ztmrh2mKT+9/vpw==", "b8e15061-0c58-400e-b1a1-3df8042d0cb7", "user@abc.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d4881d6-b06e-44b5-978c-bfcc9fcfbf29",
                column: "ConcurrencyStamp",
                value: "317635f7-b73c-469c-be84-efc1f5c70ec4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f4881d6-a06e-44b5-978c-bfcc9fcfbf29",
                column: "ConcurrencyStamp",
                value: "acb60a17-5a86-4495-b952-c85702020ade");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8ce5d0c7-0bbc-446d-b054-5c4cab8b9106", false, null, "AQAAAAEAACcQAAAAEDw56EOVqjvtOWcptxV+9bY4WzOhUdUOH+n4iZz7SJHuhL4xC8aXkCYMyL5XrAUnVA==", "33b69cd5-a4f0-42ce-ae4e-677ee2801c8e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "02498873-50f0-4a9b-ad99-30528ce525f4", false, null, "AQAAAAEAACcQAAAAEN9guzTmjK32TmMk3eojbVgsMCvQK85AdlFh9yjF1eBOkbHbl2nsJV28bOFkod7/+A==", "9233587a-35b6-47a8-bf3f-9d2d750ff3ee", null });
        }
    }
}
