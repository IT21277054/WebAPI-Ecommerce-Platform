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
        CreateMap<ProductDto, Product>().ReverseMap();
        CreateMap<ProductDetailDto, Product>().ReverseMap();
        CreateMap<CreateProductDto, Product>();
    }
}

