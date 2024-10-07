using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetByVendorId;

public record GetByVendorIdQuery(Guid Id) : IRequest<ProductDetailDto>;