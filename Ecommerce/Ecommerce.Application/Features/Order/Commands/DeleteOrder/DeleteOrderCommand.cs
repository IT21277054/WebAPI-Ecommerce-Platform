// ====================================================
// File: DeleteOrderCommand.cs
// Description: Command class for deleting an order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Commands.DeleteOrder;

// Command for deleting an order by its identifier
public record DeleteOrderCommand(Guid Id) : IRequest<Unit>;
