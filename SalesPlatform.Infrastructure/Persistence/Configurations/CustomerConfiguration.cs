using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Infrastructure.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //fluent api
            builder.HasKey(a => a.Id);

            builder.HasOne(b => b.Address)
                .WithOne(b => b.Customer);

            builder.HasOne(c => c.Contact)
                .WithOne(c => c.Customer);

            builder.HasMany(d => d.Products)
                .WithOne(d => d.Customer);

            builder.OwnsOne(e => e.CustomerName)
                .Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsRequired();

            builder.OwnsOne(f => f.CustomerName)
                .Property(f => f.LastName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(g => g.NIP)
                .HasColumnType("integer")
                .HasMaxLength(10)
                .IsRequired(false);
        }
    }
}
