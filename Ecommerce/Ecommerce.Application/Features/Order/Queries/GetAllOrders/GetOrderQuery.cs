// ====================================================
// File: GetOrderQuery.cs
// Description: Query class for retrieving all orders.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Queries.GetAllOrders;

// Query for retrieving all orders, returning a list of OrderDto
public record GetOrderQuery : IRequest<List<OrderDto>>;
