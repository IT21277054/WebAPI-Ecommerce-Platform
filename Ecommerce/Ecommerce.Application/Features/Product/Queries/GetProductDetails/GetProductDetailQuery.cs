using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetProductDetails;

public record GetProductDetailQuery(int Id) : IRequest<ProductDetailDto>;
