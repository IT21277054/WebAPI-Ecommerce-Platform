using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetAllProducts;

public record GetProductQuery : IRequest<List<ProductDto>>;
