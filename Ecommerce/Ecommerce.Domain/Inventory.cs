// ====================================================
// File: Inventory.cs
// Description: Entity representing inventory information for products.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Inventory : BaseEntity<Guid>
{
    public string CategoryName { get; set; }
    public Guid ProductId { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal? UnitPrice { get; set; }
    public int? Quantity { get; set; }
}
