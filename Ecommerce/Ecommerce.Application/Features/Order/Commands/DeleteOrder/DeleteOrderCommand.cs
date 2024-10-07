using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.DeleteOrder;

public record DeleteOrderCommand(Guid Id) : IRequest<Unit>;