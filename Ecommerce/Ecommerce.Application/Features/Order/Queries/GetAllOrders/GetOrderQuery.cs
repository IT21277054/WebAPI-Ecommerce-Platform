using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetAllOrders;

public record GetOrderQuery : IRequest<List<OrderDto>>;
