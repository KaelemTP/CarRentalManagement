using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7273fbc2-c198-4511-9274-db181ca9899d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEL0aHnzy4sIO8gDLSiDKVUV0uTRG5bVjeAkCVPAXn4IdQFsKqtZQgMXboVAsF3a+uw==", null, false, "476a7879-a79d-47ba-a106-b6ee851711d8", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(8492), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(8523), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9082), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9088), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9279), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9286), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9291), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9295), new DateTime(2025, 11, 27, 14, 5, 32, 776, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(1740), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(1767), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2172), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2178), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2414), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2419), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2423), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2427), new DateTime(2025, 11, 27, 13, 52, 34, 240, DateTimeKind.Local).AddTicks(2429) });
        }
    }
}
