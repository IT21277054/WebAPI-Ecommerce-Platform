using AutoMapper;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class CategoryProfile: Profile
{
    public CategoryProfile()
    {
          CreateMap<CategoryDto,Category>().ReverseMap();
          CreateMap<Category, CategoryDto>();
    }
}
