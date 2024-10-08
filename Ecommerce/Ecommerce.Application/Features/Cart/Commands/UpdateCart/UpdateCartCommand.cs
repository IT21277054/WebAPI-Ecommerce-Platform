// ====================================================
// File: UpdateCartCommand.cs
// Description: Command to update an existing cart with new details.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Cart.Queries.GetAllCarts;
using MediatR;

// Command to update an existing cart
public record UpdateCartCommand(CartDto dto) : IRequest<Guid>;
