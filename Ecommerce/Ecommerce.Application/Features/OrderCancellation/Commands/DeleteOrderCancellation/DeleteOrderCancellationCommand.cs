using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;

public record DeleteOrderCancellationCommand(Guid Id) : IRequest<Unit>;