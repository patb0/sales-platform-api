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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd();

            builder.OwnsOne(d => d.ProductDetails)
                .Property(d => d.ProducerName)
                .HasColumnName("ProducerName")
                .HasMaxLength(20)
                .IsRequired();

            builder.OwnsOne(e => e.ProductDetails)
                .Property(e => e.Country)
                .HasColumnName("Country")
                .HasMaxLength(20)
                .IsRequired(false);

            builder.OwnsOne(f => f.ProductDetails)
                .Property(f => f.Color)
                .HasColumnName("Color")
                .HasMaxLength(20)
                .IsRequired(false);

            builder.Property(g => g.Name)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(h => h.Price)
                .HasColumnType("decimal(9,2)")
                .HasDefaultValue(0.0)
                .IsRequired();

            builder.Property(i => i.Quantity)
                .HasColumnType("integer")
                .HasMaxLength(999)
                .IsRequired();

            builder.Property(j => j.Description)
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(k => k.VAT)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
