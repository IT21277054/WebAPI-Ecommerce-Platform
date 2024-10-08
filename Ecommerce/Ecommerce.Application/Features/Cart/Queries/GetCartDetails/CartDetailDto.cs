// ====================================================
// File: CartDetailDto.cs
// Description: Data transfer object for cart details.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;

// DTO for detailed cart information
public class CartDetailDto
{
    public ICollection<CartItem> Items { get; set; } // Items in the cart
    public string UserId { get; set; } // User associated with the cart
}
