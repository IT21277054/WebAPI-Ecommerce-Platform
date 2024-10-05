using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;

public record GetOrderCancelationDetailsQuery(int Id) : IRequest<OrderCancelationDetailDto>;
