// ====================================================
// File: InventoryDto.cs
// Description: Data Transfer Object (DTO) representing an inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;

// Data Transfer Object (DTO) representing an inventory item
public class InventoryDto
{
    public Guid Id { get; set; }
    public Guid VendorId { get; set; }
    public string Category { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal? UnitPrice { get; set; }
    public int? Quantity { get; set; }
    public bool IsAvailable { get; set; } = true;
}
