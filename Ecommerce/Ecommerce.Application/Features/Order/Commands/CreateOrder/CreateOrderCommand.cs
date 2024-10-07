using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

public record CreateOrderCommand(CreateOrderDto dto) : IRequest<Guid>;