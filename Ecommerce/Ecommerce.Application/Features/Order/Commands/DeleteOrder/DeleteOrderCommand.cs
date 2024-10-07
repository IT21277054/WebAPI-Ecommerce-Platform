using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.DeleteOrder;

public record DeleteOrderCommand(int Id) : IRequest<Unit>;