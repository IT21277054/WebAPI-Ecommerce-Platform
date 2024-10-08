// ====================================================
// File: GetOrderDetailQuery.cs
// Description: Query class for retrieving the details of a specific order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;

// Query for retrieving the details of a specific order, returning an OrderDetailDto
public record GetOrderDetailQuery(Guid Id) : IRequest<OrderDetailDto>;
