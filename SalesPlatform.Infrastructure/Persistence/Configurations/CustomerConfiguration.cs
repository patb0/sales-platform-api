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

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.OwnsOne(e => e.CustomerName)
                .Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(20)
                .IsRequired();

            builder.OwnsOne(f => f.CustomerName)
                .Property(f => f.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(g => g.NIP)
                .HasColumnType("integer")
                .HasMaxLength(10)
                .IsRequired(false);
        }
    }
}
