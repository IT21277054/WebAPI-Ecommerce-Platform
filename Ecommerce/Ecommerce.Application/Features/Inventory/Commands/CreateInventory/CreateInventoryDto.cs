namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory;

public class CreateInventoryDto
{
    public double Amount { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Catogery { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }
}
