// ====================================================
// File: CreateCartCommand.cs
// Description: Command for creating a cart entity.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart
{
    // Command for creating a new Cart
    public record CreateCartCommand(CreateCartDto dto) : IRequest<Guid>;
}
