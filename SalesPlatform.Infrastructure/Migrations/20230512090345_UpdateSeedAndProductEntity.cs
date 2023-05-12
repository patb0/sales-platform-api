using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesPlatform.Infrastructure.Migrations
{
    public partial class UpdateSeedAndProductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Height", "ProductId", "Url", "Width" },
                values: new object[,]
                {
                    { 1, 500, 1, "https://res.cloudinary.com/dshks90xq/image/upload/v1683881795/Electronics_h49ron.jpg", 500 },
                    { 2, 500, 2, "https://res.cloudinary.com/dshks90xq/image/upload/v1683881795/Home_ioiu3a.jpg", 500 },
                    { 3, 500, 3, "https://res.cloudinary.com/dshks90xq/image/upload/v1683881795/Home_ioiu3a.jpg", 500 },
                    { 4, 500, 4, "https://res.cloudinary.com/dshks90xq/image/upload/v1683881795/Fashion_eaiucr.jpg", 500 },
                    { 5, 500, 5, "https://res.cloudinary.com/dshks90xq/image/upload/v1683881794/Sports_pmdtmh.jpg", 500 },
                    { 6, 500, 6, "https://res.cloudinary.com/dshks90xq/image/upload/v1683881795/Home_ioiu3a.jpg", 500 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 5, 12, 11, 3, 44, 948, DateTimeKind.Local).AddTicks(9424));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(700));
        }
    }
}
