using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetProductByCategory;

public record GetProductByCategoryQuery(string catogery) : IRequest<List<ProductDto>>;