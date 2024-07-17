using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Data.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature()
                { 
                    Id = 1, 
                    ProductId = 1, 
                    Color = "Yasil", 
                    Height = 100, 
                    Width = 50 
                },
                new ProductFeature()
                {
                    Id = 2,
                    ProductId = 2,
                    Color = "Qirmizi",
                    Height = 90,
                    Width = 80
                },
                new ProductFeature()
                {
                    Id = 3,
                    ProductId = 4,
                    Color = "Goy",
                    Height = 200,
                    Width = 150
                });
        }
    }
}
