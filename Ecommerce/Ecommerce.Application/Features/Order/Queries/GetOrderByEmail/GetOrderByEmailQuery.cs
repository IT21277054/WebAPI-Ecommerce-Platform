using Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;
using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetOrderByEmail;

public record GetOrderByEmailQuery(string email) : IRequest<OrderDetailDto>;