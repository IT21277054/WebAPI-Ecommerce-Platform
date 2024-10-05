using Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.UpdateOrderCancellation;

public record UpdateOrderCancellationCommand(OrderCancelationDto dto) : IRequest<int>;
