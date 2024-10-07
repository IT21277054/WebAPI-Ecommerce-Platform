using AutoMapper;
using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class CategoryProfile: Profile
{
    public CategoryProfile()
    {
        CreateMap<CategoryDto,Category>().ReverseMap();
        CreateMap<CatgoryDetailsDto, Category>().ReverseMap();
        CreateMap<CreateCategoryDto, Category>();
    }
}
