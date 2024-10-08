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
    // Change the Product property to a Guid array
    public Guid[] Product { get; set; } = Array.Empty<Guid>();

    public Guid? UserId { get; set; }
    public string Email { get; set; }
}

