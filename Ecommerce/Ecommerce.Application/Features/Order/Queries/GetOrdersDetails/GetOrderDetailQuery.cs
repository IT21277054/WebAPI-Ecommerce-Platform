using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;

public record GetOrderDetailQuery(Guid Id) : IRequest<OrderDetailDto>;
