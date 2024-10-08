// ====================================================
// File: UpdateOrderCommand.cs
// Description: Command class for updating an existing order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Order.Queries.GetAllOrders; // DTO for order details
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Commands.UpdateOrder;

// Command for updating an existing order, returning the order's unique identifier
public record UpdateOrderCommand(OrderDto dto) : IRequest<Guid>;
