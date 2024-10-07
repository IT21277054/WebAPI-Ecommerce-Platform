using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;

public record GetOrderCancelationDetailsQuery(Guid Id) : IRequest<OrderCancelationDetailDto>;
