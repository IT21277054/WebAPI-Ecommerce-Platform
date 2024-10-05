using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;

public record GetOrderCancelationQuery : IRequest<List<OrderCancelationDto>>;