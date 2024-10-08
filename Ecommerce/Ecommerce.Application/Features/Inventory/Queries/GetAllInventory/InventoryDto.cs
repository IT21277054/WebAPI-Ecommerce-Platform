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
    public double Amount { get; set; }
    public string Level { get; set; } = string.Empty;    
    public string Category { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } 
}
