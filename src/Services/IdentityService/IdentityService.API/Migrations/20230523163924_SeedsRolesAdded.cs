using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityService.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedsRolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3eb075b7-2e11-420d-9393-205bc762d56e", "1", "Admin", "Admin" },
                    { "cbccd613-acc5-4c5a-b697-8cd444ce9bba", "3", "HR", "HR" },
                    { "d8a7c184-3918-4d4d-ab34-5eb9b1c0e6d5", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eb075b7-2e11-420d-9393-205bc762d56e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbccd613-acc5-4c5a-b697-8cd444ce9bba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a7c184-3918-4d4d-ab34-5eb9b1c0e6d5");
        }
    }
}
