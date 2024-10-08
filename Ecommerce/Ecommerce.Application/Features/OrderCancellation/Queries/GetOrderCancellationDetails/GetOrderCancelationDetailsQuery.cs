// ====================================================
// File: GetOrderCancelationDetailsQuery.cs
// Description: Query for retrieving the details of a specific order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;

public record GetOrderCancelationDetailsQuery(Guid Id) : IRequest<OrderCancelationDetailDto>;
