using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockTracking.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.EntityTypeConfiguration
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a=>a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(a => a.Products)
                   .WithOne(a => a.Category)
                   .HasForeignKey(a=>a.CategoryId);
        }
    }
}
