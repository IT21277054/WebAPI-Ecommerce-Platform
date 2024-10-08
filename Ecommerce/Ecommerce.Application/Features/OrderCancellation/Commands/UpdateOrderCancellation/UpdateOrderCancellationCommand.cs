// ====================================================
// File: UpdateOrderCancellationCommand.cs
// Description: Command class for updating an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation; // DTO for order cancellation
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.OrderCancellation.Commands.UpdateOrderCancellation;

// Command for updating an order cancellation, returning a Guid result
public record UpdateOrderCancellationCommand(OrderCancelationDto dto) : IRequest<Guid>;
