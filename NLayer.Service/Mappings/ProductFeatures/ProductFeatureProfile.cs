using AutoMapper;
using NLayer.Core.DTOs.ProductFeatures;
using NLayer.Core.DTOs.Products;
using NLayer.Core.DTOs.ProductsWithCategory;
using NLayer.Core.Models;

namespace NLayer.Service.Mappings.ProductFeatures
{
    public class ProductFeatureProfile : Profile
    {
        public ProductFeatureProfile()
        {
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
        }
    }
}
