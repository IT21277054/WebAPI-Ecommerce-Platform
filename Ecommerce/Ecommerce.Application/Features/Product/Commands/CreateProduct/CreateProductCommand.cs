using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateProductCommand(ProductDto dto) : IRequest<int>;