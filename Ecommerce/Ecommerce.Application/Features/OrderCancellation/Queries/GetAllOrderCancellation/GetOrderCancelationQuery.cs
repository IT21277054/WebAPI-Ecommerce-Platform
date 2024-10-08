// ====================================================
// File: GetOrderCancelationQuery.cs
// Description: Query for retrieving all order cancellations.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;

public record GetOrderCancelationQuery : IRequest<List<OrderCancelationDto>>;
