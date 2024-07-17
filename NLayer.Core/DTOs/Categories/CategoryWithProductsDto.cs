using NLayer.Core.DTOs.Products;

namespace NLayer.Core.DTOs.Categories
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
