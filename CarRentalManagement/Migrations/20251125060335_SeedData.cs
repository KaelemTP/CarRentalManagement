using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Model",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Make",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Colour",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MyProperty", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4170), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4192), null, "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4195), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4196), null, "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MyProperty", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4426), null, "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4428), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4429), null, "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MyProperty", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4511), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4511), null, "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4514), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4514), null, "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4516), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4517), null, "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4518), new DateTime(2025, 11, 25, 14, 3, 34, 455, DateTimeKind.Local).AddTicks(4519), null, "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Make");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Colour");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Booking");
        }
    }
}
