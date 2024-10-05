using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;

public record GetOrderDetailQuery(int Id) : IRequest<OrderDetailDto>;
