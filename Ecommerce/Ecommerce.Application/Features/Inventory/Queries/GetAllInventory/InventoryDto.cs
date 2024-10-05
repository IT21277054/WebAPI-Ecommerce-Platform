namespace Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;

public class InventoryDto
{
    public int Id { get; set; }
    public int Amount { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Catogery { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }
}
