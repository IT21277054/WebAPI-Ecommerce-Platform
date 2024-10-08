// ====================================================
// File: ProductProfile.cs
// Description: AutoMapper profile for mapping Product entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        // Map ProductDto to Product and vice versa
        CreateMap<ProductDto, Product>().ReverseMap();

        // Map ProductDetailsDto to Product and vice versa
        CreateMap<ProductDetailDto, Product>().ReverseMap();

        // Map CreateProductDto to Product (for creating new products)
        CreateMap<CreateProductDto, Product>();
    }
}