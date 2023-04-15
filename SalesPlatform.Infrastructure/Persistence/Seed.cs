using Microsoft.EntityFrameworkCore;
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
            //added default customers
            modelBuilder.Entity<Customer>(d =>
                {
                    d.HasData(new Customer()
                    {
                        Id = 1,
                        StatusId = 1,
                        Created = DateTime.Now,
                        CustomerName = new CustomerName("Patryk", "Boguslawski"),
                        Contact = new Contact()
                        {
                            Email = Email.For("pat@bog.pl"),
                            PhoneNumber = "123456789",
                        },
                        Address = new Address()
                        {
                            Country = "Poland",
                            City = "Warsaw",
                            ZipCode = "00-000",
                            Street = "Kwiatowa",
                            FlatNumber = "1",
                        },
                        
                    });
                }
            );

            //added default products
            //modelBuilder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        Id = 1,
            //        Condition = Domain.Enums.ProductCondition.New,
            //        Category = Domain.Enums.ProductCategory.Electronics,
            //        ProductDetails = new ProductDetails("Asus", "England", "black"),
            //        Name = "Asus laptop",
            //        Price = 500,
            //        Quantity = 1,
            //        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
            //        VAT = true,
            //        CustomerId = 1,
            //        Created = DateTime.Now,
            //    }
            //);
        }
    }
}
