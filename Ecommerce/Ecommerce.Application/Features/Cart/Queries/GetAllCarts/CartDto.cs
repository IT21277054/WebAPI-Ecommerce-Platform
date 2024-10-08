// ====================================================
// File: CartDto.cs
// Description: Data transfer object for Cart, used for transferring cart data between layers.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

public class CartDto
{
    public Guid Id { get; set; } // Unique identifier for the cart
    public ICollection<CartItem> Items { get; set; } // Collection of items in the cart
    public string UserId { get; set; } // Identifier for the user owning the cart
}
