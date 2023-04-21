using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesPlatform.Infrastructure.Migrations
{
    public partial class SeedSimpleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Accounts");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "FlatNumber", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Warsaw", 0, "1a", "Kwiatowa", "00-000" },
                    { 2, "London", 1, "19", "Backer", "93-400" },
                    { 3, "London", 1, "19", "Backer", "93-400" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "EmailAddress", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "patbog@mail.com", "123456789" },
                    { 2, "damian@mail.com", "987654321" },
                    { 3, "damian@mail.com", "987654321" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Login", "PasswordHash", "RoleId" },
                values: new object[] { 1, "patryk", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Login", "PasswordHash", "RoleId" },
                values: new object[] { 2, "damian", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 2 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Login", "PasswordHash", "RoleId" },
                values: new object[] { 3, "patrol", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "AddressId", "ContactId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "NIP", "StatusId", "FirstName", "LastName" },
                values: new object[] { 1, 1, 1, 1, new DateTime(2023, 4, 21, 18, 59, 56, 274, DateTimeKind.Local).AddTicks(677), "Admin", null, null, null, null, null, 1, "Patryk", "Boguslawski" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "AddressId", "ContactId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "NIP", "StatusId", "FirstName", "LastName" },
                values: new object[] { 2, 2, 2, 2, new DateTime(2023, 4, 21, 18, 59, 56, 274, DateTimeKind.Local).AddTicks(716), "Admin", null, null, null, null, null, 1, "Damian", "Boguslawski" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "UserId", "VAT", "Color", "Country", "ProducerName" },
                values: new object[] { 1, 0, 0, new DateTime(2023, 4, 21, 18, 59, 56, 274, DateTimeKind.Local).AddTicks(1002), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name1", 500m, 1, 1, 1, true, "Black", "Poland", "Asus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "UserId", "Color", "Country", "ProducerName" },
                values: new object[] { 2, 4, 0, new DateTime(2023, 4, 21, 18, 59, 56, 274, DateTimeKind.Local).AddTicks(1011), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name2", 200m, 5, 1, 1, "Red", "England", "Pepco" });

            migrationBuilder.InsertData(
                table: "Opinions",
                columns: new[] { "Id", "Comment", "ProductId", "Rating" },
                values: new object[] { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 5 });

            migrationBuilder.InsertData(
                table: "Opinions",
                columns: new[] { "Id", "Comment", "ProductId", "Rating" },
                values: new object[] { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "Accounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Accounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
