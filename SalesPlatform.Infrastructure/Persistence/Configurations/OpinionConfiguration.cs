﻿using Microsoft.EntityFrameworkCore;
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
            builder.HasKey(x => x.Id);

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Comment)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(d => d.Rating)
                .HasMaxLength(5)
                .IsRequired();
        }
    }
}
