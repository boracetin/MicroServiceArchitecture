using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TenantService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class TenantDomainUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubscriptionStartDay",
                table: "Tenants",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubscriptionEndDay",
                table: "Tenants",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EditionId",
                table: "Tenants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 6, 8, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9034), new DateTime(2023, 6, 8, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9037), new DateTime(2023, 6, 8, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9041), new DateTime(2023, 5, 29, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 6, 18, 17, 57, 11, 207, DateTimeKind.Local).AddTicks(9040) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubscriptionStartDay",
                table: "Tenants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubscriptionEndDay",
                table: "Tenants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EditionId",
                table: "Tenants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4445), new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4326), new DateTime(2023, 6, 8, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4459), new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 6, 8, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4463), new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 6, 8, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4466), new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 6, 18, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4466) });
        }
    }
}
