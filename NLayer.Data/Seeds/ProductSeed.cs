using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Data.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() 
                { 
                    Id = 1, 
                    CategoryId = 1, 
                    Name = "Qelem 1",
                    Price = 100, 
                    Stock = 20, 
                    CreatedDate = DateTime.Now 
                },
                new Product()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Qelem 2",
                    Price = 200,
                    Stock = 30,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Qelem 3",
                    Price = 500,
                    Stock = 40,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Kitab 1",
                    Price = 800,
                    Stock = 10,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 5,
                    CategoryId = 3,
                    Name = "Defter 1",
                    Price = 650,
                    Stock = 25,
                    CreatedDate = DateTime.Now
                });
        }
    }
}
