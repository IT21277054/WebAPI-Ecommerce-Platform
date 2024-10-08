// ====================================================
// File: CategoryProfile.cs
// Description: AutoMapper profile for mapping Category entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        // Map CategoryDto to Category and vice versa
        CreateMap<CategoryDto, Category>().ReverseMap();

        // Map CatgoryDetailsDto to Category and vice versa
        CreateMap<CatgoryDetailsDto, Category>().ReverseMap();

        // Map CreateCategoryDto to Category (for creating new categories)
        CreateMap<CreateCategoryDto, Category>();
    }
}