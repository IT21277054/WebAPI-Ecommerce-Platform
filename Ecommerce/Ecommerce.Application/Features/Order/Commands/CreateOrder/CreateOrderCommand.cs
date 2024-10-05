using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

public record CreateOrderCommand(OrderDto dto) : IRequest<int>;