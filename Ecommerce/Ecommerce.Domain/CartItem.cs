// ====================================================
// File: CartItem.cs
// Description: Entity representing an item in the shopping cart.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Domain;

public class CartItem
{
    public string ProductId { get; set; }
    public Guid Quantity { get; set; }
    public decimal Price { get; set; }
}
