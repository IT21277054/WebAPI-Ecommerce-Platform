using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using MediatR;

namespace Ecommerce.Application.Features.Product.Commands.UpdateProduct;

public record UpdateProductCommand(ProductDto dto) : IRequest<Guid>;
