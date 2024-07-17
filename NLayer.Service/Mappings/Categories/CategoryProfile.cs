using AutoMapper;
using NLayer.Core.DTOs.Categories;
using NLayer.Core.Models;

namespace NLayer.Service.Mappings.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
