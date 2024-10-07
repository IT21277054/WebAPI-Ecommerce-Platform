using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateOrderCancellationCommand(CreateOrderCancellationDto dto) : IRequest<Guid>;
