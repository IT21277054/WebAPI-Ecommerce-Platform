// ====================================================
// File: Product.cs
// Description: Entity representing a product in the system.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Product : BaseEntity<Guid>
{
    public Guid CartId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public Guid? VendorId { get; set; }
    public bool IsActivated { get; set; }
}
