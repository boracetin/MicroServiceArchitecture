using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EditionService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 5, 30, 1, 30, 15, 174, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 5, 30, 1, 30, 15, 174, DateTimeKind.Local).AddTicks(1645));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 5, 30, 1, 13, 26, 426, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 5, 30, 1, 13, 26, 426, DateTimeKind.Local).AddTicks(371));
        }
    }
}
