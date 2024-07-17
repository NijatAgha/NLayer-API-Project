using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Data.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category() { Id = 1, Name = "Qelemler" },
                new Category() { Id = 2, Name = "Kitablar" },
                new Category() { Id = 3, Name = "Defterler" });
        }
    }
}
