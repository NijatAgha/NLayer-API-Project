using NLayer.Core.DTOs;
using NLayer.Core.DTOs.ProductsWithCategory;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IProductService : IService<Product>
    { 
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategoryAsync();
    }
}
