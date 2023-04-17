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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //builder.HasOne(b => b.Customer)
            //    .WithOne(b => b.Contact);

            //builder.OwnsOne(c => c.Email)
            //    .Property(c => c.UserName)
            //    .HasMaxLength(20)
            //    .IsRequired();

            //builder.OwnsOne(d => d.Email)
            //    .Property(d => d.Domain)
            //    .HasMaxLength(20)
            //    .IsRequired();

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}
