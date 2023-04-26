using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesPlatform.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "FlatNumber", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Warsaw", 0, "1a", "Kwiatowa", "00-000" },
                    { 2, "London", 1, "19", "Backer", "93-400" },
                    { 3, "London", 1, "19", "Backer", "93-400" },
                    { 4, "Oslo", 12, "102a", "Lorem", "93-400" },
                    { 5, "Amsterdam", 7, "88", "Lorem", "93-400" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "EmailAddress", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "patbog@mail.com", "123456789" },
                    { 2, "damian@mail.com", "987654321" },
                    { 3, "damian@mail.com", "987654321" },
                    { 4, "adas@pl.com", "992003991" },
                    { 5, "kasia@xp.com", "9908882991" }
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
                values: new object[,]
                {
                    { 1, "patryk", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 1 },
                    { 2, "damian", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 2 },
                    { 3, "patrol", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 2 },
                    { 4, "adam", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 2 },
                    { 5, "kasia", "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "AddressId", "ContactId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "NIP", "StatusId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9674), "Admin", null, null, null, null, null, 1, "Patryk", "Boguslawski" },
                    { 2, 2, 2, 2, new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9710), "Admin", null, null, null, null, null, 1, "Damian", "Boguslawski" },
                    { 3, 3, 3, 3, new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9713), "Admin", null, null, null, null, null, 1, "Jan", "Kowalski" },
                    { 4, 4, 4, 4, new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9715), "Admin", null, null, null, null, null, 1, "Adam", "Kozak" },
                    { 5, 5, 5, 5, new DateTime(2023, 4, 26, 11, 10, 9, 696, DateTimeKind.Local).AddTicks(9717), "Admin", null, null, null, null, null, 1, "Katarzyna", "Szybka" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "UserId", "VAT", "Color", "Country", "ProducerName" },
                values: new object[] { 1, 0, 0, new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(227), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name1", 500m, 1, 1, 1, true, "Black", "Poland", "Asus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "UserId", "Color", "Country", "ProducerName" },
                values: new object[,]
                {
                    { 2, 4, 0, new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(236), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name2", 200m, 5, 1, 1, "Red", "England", "Pepco" },
                    { 3, 2, 0, new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(239), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name3", 250m, 15, 1, 2, "Blue", "Czech", "Sparco" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "UserId", "VAT", "Color", "Country", "ProducerName" },
                values: new object[,]
                {
                    { 4, 3, 0, new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(241), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name 4", 99m, 1, 1, 3, true, "White", "Norway", "Nike" },
                    { 5, 1, 0, new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(243), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name 5", 23m, 99, 1, 4, true, "Green", "Finland", "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "UserId", "Color", "Country", "ProducerName" },
                values: new object[] { 6, 4, 0, new DateTime(2023, 4, 26, 11, 10, 9, 697, DateTimeKind.Local).AddTicks(246), "Admin", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name 6", 88m, 9, 1, 5, "Purple", "Denmark", "Pepco" });

            migrationBuilder.InsertData(
                table: "Opinions",
                columns: new[] { "Id", "Comment", "ProductId", "Rating" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 5 },
                    { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 3 },
                    { 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 3, 5 },
                    { 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 4, 5 },
                    { 5, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 5, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Opinions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
