using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesPlatform.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerName_LastName",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "CustomerName_FirstName",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "FlatNumber", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Warsaw", 0, "1a", "Kwiatowa", "00-000" },
                    { 2, "London", 1, "19", "Backer", "93-400" },
                    { 3, "Kreta", 26, "10/2", "Backer", "93-400" },
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
                    { 3, "jan@mail.com", "388499201" },
                    { 4, "adas@pl.com", "992003991" },
                    { 5, "kasia@xp.com", "9908882991" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "ContactId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "NIP", "StatusId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(89), "Admin", null, null, null, null, null, 1, "Patryk", "Boguslawski" },
                    { 2, 2, 2, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(154), "Admin", null, null, null, null, null, 1, "Damian", "Boguslawski" },
                    { 3, 3, 3, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(157), "Admin", null, null, null, null, null, 1, "Jan", "Kowalski" },
                    { 4, 4, 4, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(159), "Admin", null, null, null, null, null, 1, "Adam", "Kozak" },
                    { 5, 5, 5, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(161), "Admin", null, null, null, null, null, 1, "Katarzyna", "Szybka" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "CustomerId", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "VAT", "ProductDetails_Color", "ProductDetails_Country", "ProductDetails_ProducerName" },
                values: new object[] { 1, 0, 0, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(792), "Admin", 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name1", 500m, 1, 1, true, "Black", "Poland", "Asus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "CustomerId", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "ProductDetails_Color", "ProductDetails_Country", "ProductDetails_ProducerName" },
                values: new object[,]
                {
                    { 2, 4, 0, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(803), "Admin", 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name2", 200m, 5, 1, "Red", "England", "Pepco" },
                    { 3, 2, 0, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(806), "Admin", 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name3", 250m, 15, 1, "Blue", "Czech", "Sparco" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "CustomerId", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "VAT", "ProductDetails_Color", "ProductDetails_Country", "ProductDetails_ProducerName" },
                values: new object[,]
                {
                    { 4, 3, 0, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(808), "Admin", 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name 4", 99m, 1, 1, true, "White", "Norway", "Nike" },
                    { 5, 1, 0, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(811), "Admin", 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name 5", 23m, 99, 1, true, "Green", "Finland", "Adidas" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Condition", "Created", "CreatedBy", "CustomerId", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "Quantity", "StatusId", "ProductDetails_Color", "ProductDetails_Country", "ProductDetails_ProducerName" },
                values: new object[] { 6, 4, 0, new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(813), "Admin", 5, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null, null, null, null, "Product name 6", 88m, 9, 1, "Purple", "Denmark", "Pepco" });

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
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
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

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "CustomerName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "CustomerName_FirstName");
        }
    }
}
