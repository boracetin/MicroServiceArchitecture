using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TenantService.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "EditionId", "EmailAddress", "IsDeleted", "Name", "SubscriptionEndDay", "SubscriptionStartDay", "Surname" },
                values: new object[] { 4, new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4466), null, 3, "pinar@outlook.com", true, "pinar", new DateTime(2023, 5, 29, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 6, 18, 11, 51, 58, 214, DateTimeKind.Local).AddTicks(4466), "uyar" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 6, 8, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "SubscriptionEndDay", "SubscriptionStartDay" },
                values: new object[] { new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4643), new DateTime(2023, 5, 29, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4642), new DateTime(2023, 6, 8, 11, 49, 24, 745, DateTimeKind.Local).AddTicks(4642) });
        }
    }
}
