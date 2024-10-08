namespace Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;

public class InventoryDto
{
    public Guid Id { get; set; }
    public double Amount { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Catogery { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }
}
