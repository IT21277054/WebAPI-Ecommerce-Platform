// ====================================================
// File: Cart.cs
// Description: Entity representing a shopping cart.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Cart : BaseEntity<Guid>
{
    public ICollection<CartItem> Items { get; set; }
    public string UserId { get; set; }
}
