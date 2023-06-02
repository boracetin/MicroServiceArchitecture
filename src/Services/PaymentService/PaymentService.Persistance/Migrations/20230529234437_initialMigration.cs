using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PaymentService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    SuccessUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedTime", "DeletedTime", "ErrorUrl", "IsDeleted", "PaymentStatus", "SuccessUrl", "TenantId" },
                values: new object[,]
                {
                    { 1, 10f, new DateTime(2023, 5, 29, 23, 44, 37, 171, DateTimeKind.Utc).AddTicks(91), null, "www.deneme.com/erroUrl", false, 2, "www.boracetin.com/successUrl", 1 },
                    { 2, 20f, new DateTime(2023, 5, 29, 23, 44, 37, 171, DateTimeKind.Utc).AddTicks(100), null, "www.deneme.com/erroUrl", false, 3, "www.admin.com/successUrl", 1 },
                    { 3, 30f, new DateTime(2023, 5, 29, 23, 44, 37, 171, DateTimeKind.Utc).AddTicks(101), null, "www.deneme.com/erroUrl", false, 1, "www.pinar.com/successUrl", 1 },
                    { 4, 40f, new DateTime(2023, 5, 29, 23, 44, 37, 171, DateTimeKind.Utc).AddTicks(102), null, "www.deneme.com/erroUrl", false, 4, "www.selma.com/successUrl", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
