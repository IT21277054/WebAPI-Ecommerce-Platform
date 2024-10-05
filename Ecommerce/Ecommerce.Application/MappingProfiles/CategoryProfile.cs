using AutoMapper;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.MappingProfiles;

public class CategoryProfile: Profile
{
    public CategoryProfile()
    {
          CreateMap<CategoryDto,Category>().ReverseMap();
          CreateMap<Category, CategoryDto>();
    }
}
