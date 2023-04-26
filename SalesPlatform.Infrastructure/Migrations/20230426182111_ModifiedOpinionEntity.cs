using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesPlatform.Infrastructure.Migrations
{
    public partial class ModifiedOpinionEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "Opinions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedBy",
                value: "Jan Kowalski");

            migrationBuilder.UpdateData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedBy",
                value: "Adam Kozak");

            migrationBuilder.UpdateData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedBy",
                value: "Patryk Boguslawski");

            migrationBuilder.UpdateData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedBy",
                value: "Katarzyna Szybka");

            migrationBuilder.UpdateData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedBy",
                value: "Damian Boguslawski");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 969, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 969, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 969, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 969, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 969, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 969, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 968, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 968, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 968, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 968, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 26, 20, 21, 10, 968, DateTimeKind.Local).AddTicks(9799));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Opinions");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9717));
        }
    }
}
