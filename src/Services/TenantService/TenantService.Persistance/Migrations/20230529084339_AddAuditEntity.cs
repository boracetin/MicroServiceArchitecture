using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TenantService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Tenants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Tenants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EditionId",
                table: "Tenants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tenants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriptionEndDay",
                table: "Tenants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriptionStartDay",
                table: "Tenants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "DeletedTime", "EditionId", "IsDeleted", "Name", "SubscriptionEndDay", "SubscriptionStartDay", "Surname" },
                values: new object[] { null, null, 1, false, "admin", new DateTime(2023, 5, 29, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(382), new DateTime(2023, 6, 8, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(397), "admin" });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "DeletedTime", "EditionId", "IsDeleted", "Name", "SubscriptionEndDay", "SubscriptionStartDay", "Surname" },
                values: new object[] { null, null, 1, false, "bora", new DateTime(2023, 5, 29, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 6, 8, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(412), "cetin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "EditionId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "SubscriptionEndDay",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "SubscriptionStartDay",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Tenants");

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Default");
        }
    }
}
