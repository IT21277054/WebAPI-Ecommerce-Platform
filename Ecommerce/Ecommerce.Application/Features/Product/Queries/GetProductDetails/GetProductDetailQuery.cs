using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetProductDetails;

public record GetProductDetailQuery(Guid Id) : IRequest<ProductDetailDto>;
