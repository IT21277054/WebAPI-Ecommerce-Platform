// ====================================================
// File: CreateOrderCommand.cs
// Description: Command class for creating a new order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

// DTO for creating a new order
public record CreateOrderCommand(CreateOrderDto dto) : IRequest<Guid>;
