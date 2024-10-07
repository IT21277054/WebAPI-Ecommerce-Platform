using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateProductCommand(CreateProductDto dto) : IRequest<Guid>;