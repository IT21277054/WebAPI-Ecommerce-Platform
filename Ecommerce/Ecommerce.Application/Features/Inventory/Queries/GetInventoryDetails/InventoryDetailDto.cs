// ====================================================
// File: InventoryDetailDto.cs
// Description: Data Transfer Object (DTO) representing the details of an inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;

// DTO for retrive a new inventory item
public class InventoryDetailDto
{
    public Guid Id { get; set; }
    public double Amount { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Catogery { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }
}
