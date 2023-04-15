using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
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
            //to do
            //add more seed data


            //added default customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                }
            );

            //added default products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                }
            );
        }
    }
}
