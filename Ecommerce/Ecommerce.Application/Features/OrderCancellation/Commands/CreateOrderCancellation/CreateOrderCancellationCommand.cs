// ====================================================
// File: CreateOrderCancellationCommand.cs
// Description: Command class for creating an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

// Command for creating an order cancellation, returning a Guid identifier
public record CreateOrderCancellationCommand(CreateOrderCancellationDto dto) : IRequest<Guid>;
