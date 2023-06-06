using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TenantService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: true),
                    SubscriptionEndDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionStartDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "EditionId", "EmailAddress", "IsDeleted", "Name", "SubscriptionEndDay", "SubscriptionStartDay", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2233), null, 1, "admin@outlook.com", false, "admin", new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 6, 16, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2227), "admin" },
                    { 2, new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2250), null, 2, "default@outlook.com", false, "default", new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 6, 16, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2249), "default" },
                    { 3, new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2253), null, 1, "default@outlook.com", false, "bora", new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2251), new DateTime(2023, 6, 16, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2252), "cetin" },
                    { 4, new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2255), null, 3, "pinar@outlook.com", true, "pinar", new DateTime(2023, 6, 6, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2254), new DateTime(2023, 6, 26, 12, 5, 56, 184, DateTimeKind.Local).AddTicks(2255), "uyar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
