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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //fluent api
            builder.HasKey(x => x.Id);

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd();

            //builder.OwnsOne(x => x.UserName);

            builder.OwnsOne(e => e.UserName)
                .Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(20)
                .IsRequired();

            builder.OwnsOne(e => e.UserName)
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
