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
    public class OpinionConfiguration : IEntityTypeConfiguration<Opinion>
    {
        public void Configure(EntityTypeBuilder<Opinion> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //builder.HasOne(b => b.Product)
            //    .WithMany(b => b.Opinions)
            //    .HasForeignKey(b => b.ProductId);

            builder.Property(c => c.Comment)
                .HasMaxLength(100)
                .IsRequired(false);
        }
    }
}
