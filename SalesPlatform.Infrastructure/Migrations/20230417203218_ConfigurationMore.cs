using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesPlatform.Infrastructure.Migrations
{
    public partial class ConfigurationMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Contacts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 822, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 822, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 822, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 822, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 822, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 823, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 823, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 823, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 823, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 823, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 32, 17, 823, DateTimeKind.Local).AddTicks(413));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(813));
        }
    }
}
