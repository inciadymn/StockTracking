using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockTracking.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.Concrete.Context.EntityTypeConfiguration
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(a=>a.Id);

            builder.Property(a => a.Id)
                   .UseIdentityColumn();

            builder.Property(a => a.Name)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(a => a.Quantity)
                   .IsRequired();
        }
    }
}
