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
    public Guid VendorId { get; set; }
    public string VendorName { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal? UnitPrice { get; set; }
    public int? Quantity { get; set; }
}
