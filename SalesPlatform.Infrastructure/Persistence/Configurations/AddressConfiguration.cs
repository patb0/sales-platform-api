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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasOne(b => b.Customer)
                .WithOne(b => b.Address);

            builder.Property(c => c.Country)
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(d => d.City)
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.ZipCode)
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(f => f.Street)
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(g => g.FlatNumber)
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
