using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;

public record DeleteOrderCancellationCommand(int Id) : IRequest<Unit>;