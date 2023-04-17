using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Infrastructure.Persistence
{
    public static class Seed
    {

        public static void SeedData(this ModelBuilder modelBuilder)
        {
            //added customers
            modelBuilder.Entity<Customer>(d =>
                {
                    d.HasData(
                        new Customer()
                        {
                            Id = 1,
                            StatusId = 1,
                            Created = DateTime.Now,
                            CreatedBy = "Admin",
                            ContactId = 1,
                            AddressId = 1,
                        },
                        new Customer()
                        {
                            Id = 2,
                            StatusId = 1,
                            Created = DateTime.Now,
                            CreatedBy = "Admin",
                            ContactId = 2,
                            AddressId = 2,
                        },
                        new Customer()
                        {
                            Id = 3,
                            StatusId = 1,
                            Created = DateTime.Now,
                            CreatedBy = "Admin",
                            ContactId = 3,
                            AddressId = 3,
                        },
                        new Customer()
                        {
                            Id = 4,
                            StatusId = 1,
                            Created = DateTime.Now,
                            CreatedBy = "Admin",
                            ContactId = 4,
                            AddressId = 4,
                        },
                        new Customer()
                        {
                            Id = 5,
                            StatusId = 1,
                            Created = DateTime.Now,
                            CreatedBy = "Admin",
                            ContactId = 5,
                            AddressId = 5,
                        });
                        d.OwnsOne(d => d.CustomerName).HasData(
                            new { CustomerId = 1, FirstName = "Patryk", LastName = "Boguslawski" });
                        d.OwnsOne(d => d.CustomerName).HasData(
                            new { CustomerId = 2, FirstName = "Damian", LastName = "Boguslawski" });
                        d.OwnsOne(d => d.CustomerName).HasData(
                            new { CustomerId = 3, FirstName = "Jan", LastName = "Kowalski" });
                        d.OwnsOne(d => d.CustomerName).HasData(
                            new { CustomerId = 4, FirstName = "Adam", LastName = "Kozak" });
                        d.OwnsOne(d => d.CustomerName).HasData(
                            new { CustomerId = 5, FirstName = "Katarzyna", LastName = "Szybka" });
                }
            );

            //added contacts
            modelBuilder.Entity<Contact>(d =>
                {
                    d.HasData(
                        new Contact
                        {
                            Id = 1,
                            PhoneNumber = "123456789",
                            EmailAddress = "patbog@mail.com",
                        },
                        new Contact
                        {
                            Id = 2,
                            PhoneNumber = "987654321",
                            EmailAddress = "damian@mail.com",
                        },
                        new Contact
                        {
                            Id = 3,
                            PhoneNumber = "388499201",
                            EmailAddress = "jan@mail.com",
                        },
                        new Contact
                        {
                            Id = 4,
                            PhoneNumber = "992003991",
                            EmailAddress = "adas@pl.com",
                        },
                        new Contact
                        {
                            Id = 5,
                            PhoneNumber = "9908882991",
                            EmailAddress = "kasia@xp.com",
                        });
                }
            );

            //added addresses
            modelBuilder.Entity<Address>(d =>
            {
                d.HasData(
                    new Address
                    {
                        Id = 1,
                        Country = Domain.Enums.Country.Poland,
                        ZipCode = "00-000",
                        City = "Warsaw",
                        Street = "Kwiatowa",
                        FlatNumber = "1a",
                    },
                    new Address
                    {
                        Id = 2,
                        Country = Domain.Enums.Country.England,
                        ZipCode = "93-400",
                        City = "London",
                        Street = "Backer",
                        FlatNumber = "19",
                    },
                    new Address
                    {
                        Id = 3,
                        Country = Domain.Enums.Country.Czech,
                        ZipCode = "93-400",
                        City = "Kreta",
                        Street = "Backer",
                        FlatNumber = "10/2",
                    },
                    new Address
                    {
                        Id = 4,
                        Country = Domain.Enums.Country.Norway,
                        ZipCode = "93-400",
                        City = "Oslo",
                        Street = "Lorem",
                        FlatNumber = "102a",
                    },
                    new Address
                    {
                        Id = 5,
                        Country = Domain.Enums.Country.Netherlands,
                        ZipCode = "93-400",
                        City = "Amsterdam",
                        Street = "Lorem",
                        FlatNumber = "88",
                    });
            });

            //added products
            modelBuilder.Entity<Product>(d =>
            {
                d.HasData(
                    new Product
                    {
                        Id = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "Admin",
                        CustomerId = 1,
                        Condition = Domain.Enums.ProductCondition.New,
                        Category = Domain.Enums.ProductCategory.Electronics,
                        Name = "Product name1",
                        Price = 500,
                        Quantity = 1,
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        VAT = true,
                    },
                    new Product
                    {
                        Id = 2,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "Admin",
                        CustomerId = 1,
                        Condition = Domain.Enums.ProductCondition.New,
                        Category = Domain.Enums.ProductCategory.Home,
                        Name = "Product name2",
                        Price = 200,
                        Quantity = 5,
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        VAT = false,
                    },
                    new Product
                    {
                        Id = 3,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "Admin",
                        CustomerId = 2,
                        Condition = Domain.Enums.ProductCondition.New,
                        Category = Domain.Enums.ProductCategory.Automotive,
                        Name = "Product name3",
                        Price = 250,
                        Quantity = 15,
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        VAT = false,
                    },
                    new Product
                    {
                        Id = 4,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "Admin",
                        CustomerId = 3,
                        Condition = Domain.Enums.ProductCondition.New,
                        Category = Domain.Enums.ProductCategory.Fashion,
                        Name = "Product name 4",
                        Price = 99,
                        Quantity = 1,
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        VAT = true,
                    },
                    new Product
                    {
                        Id = 5,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "Admin",
                        CustomerId = 4,
                        Condition = Domain.Enums.ProductCondition.New,
                        Category = Domain.Enums.ProductCategory.Sports,
                        Name = "Product name 5",
                        Price = 23,
                        Quantity = 99,
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        VAT = true,
                    },
                    new Product
                    {
                        Id = 6,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CreatedBy = "Admin",
                        CustomerId = 5,
                        Condition = Domain.Enums.ProductCondition.New,
                        Category = Domain.Enums.ProductCategory.Home,
                        Name = "Product name 6",
                        Price = 88,
                        Quantity = 9,
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                        VAT = false,
                    });
                d.OwnsOne(d => d.ProductDetails).HasData(
                    new { ProductId = 1, ProducerName = "Asus", Country = Domain.Enums.Country.Poland.ToString(), Color = "Black" });
                d.OwnsOne(d => d.ProductDetails).HasData(
                    new { ProductId = 2, ProducerName = "Pepco", Country = Domain.Enums.Country.England.ToString(), Color = "Red" });
                d.OwnsOne(d => d.ProductDetails).HasData(
                    new { ProductId = 3, ProducerName = "Sparco", Country = Domain.Enums.Country.Czech.ToString(), Color = "Blue" });
                d.OwnsOne(d => d.ProductDetails).HasData(
                    new {ProductId = 4, ProducerName = "Nike", Country = Domain.Enums.Country.Norway.ToString(), Color = "White" });
                d.OwnsOne(d => d.ProductDetails).HasData(
                    new { ProductId = 5, ProducerName = "Adidas", Country = Domain.Enums.Country.Finland.ToString(), Color = "Green" });
                d.OwnsOne(d => d.ProductDetails).HasData(
                    new { ProductId = 6, ProducerName = "Pepco", Country = Domain.Enums.Country.Denmark.ToString(), Color = "Purple" });
            });

            //added opinions
            modelBuilder.Entity<Opinion>(d =>
            {
            d.HasData(
                new Opinion
                {
                    Id = 1,
                    Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Rating = 5,
                    ProductId = 1,
                },
                new Opinion
                {
                    Id = 2,
                    Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Rating = 3,
                    ProductId = 2,
                },
                new Opinion
                {
                    Id = 3,
                    Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Rating = 5,
                    ProductId = 3,
                },
                new Opinion
                {
                    Id = 4,
                    Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Rating = 5,
                    ProductId = 4,
                },
                new Opinion
                {
                    Id = 5,
                    Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Rating = 1,
                    ProductId = 5,
                });
            });
        }
    }
}
