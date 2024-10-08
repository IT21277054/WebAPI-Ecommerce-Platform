using AutoMapper;
using Ecommerce.Application.Features.Cart.Queries.GetAllCarts;
using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.MappingProfiles;

public class CartProfile : Profile
{
    public CartProfile()
    {
        // Map CartDto to Cart and vice versa
        CreateMap<CartDto, Cart>()
            .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product)).ReverseMap();

        CreateMap<Cart, CartDto>()
            .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));

        // Map ProductDto to Product and vice versa
        CreateMap<ProductDto, Product>().ReverseMap();
    }




}