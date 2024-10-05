using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.UpdateOrder;
public record UpdateOrderCommand(OrderDto dto) : IRequest<int>;
