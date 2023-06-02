using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EditionService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatasCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsDeleted", "Name", "Price", "TrialDay" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 30, 1, 13, 26, 426, DateTimeKind.Local).AddTicks(353), null, false, "standart", 20f, 1 },
                    { 2, new DateTime(2023, 5, 30, 1, 13, 26, 426, DateTimeKind.Local).AddTicks(371), null, false, "admin", 15f, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
