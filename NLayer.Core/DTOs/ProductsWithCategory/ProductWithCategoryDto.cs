using NLayer.Core.DTOs.Categories;
using NLayer.Core.DTOs.Products;

namespace NLayer.Core.DTOs.ProductsWithCategory
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
