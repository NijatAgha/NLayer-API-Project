using AutoMapper;
using NLayer.Core.DTOs.Products;
using NLayer.Core.DTOs.ProductsWithCategory;
using NLayer.Core.Models;

namespace NLayer.Service.Mappings.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<ProductAddDto, Product>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDto>();
        }
    }
}
