using Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateOrderCancellationCommand(OrderCancelationDto dto) : IRequest<int>;
