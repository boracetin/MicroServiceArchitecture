using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TenantService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 6, 8, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "EditionId", "Name", "SubscriptionEndDay", "SubscriptionStartDay", "Surname" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4640), 2, "default", new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 6, 8, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4639), "default" });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "EditionId", "EmailAddress", "IsDeleted", "Name", "SubscriptionEndDay", "SubscriptionStartDay", "Surname" },
                values: new object[] { 3, new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4643), null, 1, "default@outlook.com", false, "bora", new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4642), new DateTime(2023, 6, 8, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4642), "cetin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { null, new DateTime(2023, 5, 29, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(382), new DateTime(2023, 6, 8, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "EditionId", "Name", "SubscriptionEndDay", "SubscriptionStartDay", "Surname" },
                values: new object[] { null, 1, "bora", new DateTime(2023, 5, 29, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 6, 8, 11, 43, 39, 739, DateTimeKind.Local).AddTicks(412), "cetin" });
        }
    }
}
