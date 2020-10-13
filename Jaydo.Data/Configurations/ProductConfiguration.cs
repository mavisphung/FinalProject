using Jaydo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jaydo.Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("tblProduct");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Stock).HasDefaultValue<int>(0);
            builder.Property(x => x.BrandId).IsRequired(true);
            builder.Property(x => x.CategoryId).IsRequired(true);
            builder.Property(x => x.UnitPrice).IsRequired(true).HasDefaultValue<int>(0);
        }
    }
}
