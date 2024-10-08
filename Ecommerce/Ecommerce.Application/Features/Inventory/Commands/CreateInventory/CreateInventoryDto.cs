// ====================================================
// File: CreateInventoryDto.cs
// Description: Data transfer object for creating a new inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory;

// DTO for creating a new inventory item
public class CreateInventoryDto
{
    public double Amount { get; set; } 
    public string Level { get; set; } = string.Empty;
    public string Catogery { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }
}
