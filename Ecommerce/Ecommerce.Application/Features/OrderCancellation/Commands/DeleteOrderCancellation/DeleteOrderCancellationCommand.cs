// ====================================================
// File: DeleteOrderCancellationCommand.cs
// Description: Command class for deleting an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;

// Command for deleting an order cancellation, returning a Unit result
public record DeleteOrderCancellationCommand(Guid Id) : IRequest<Unit>;
