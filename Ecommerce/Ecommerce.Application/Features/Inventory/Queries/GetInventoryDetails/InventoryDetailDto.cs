namespace Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;

public class InventoryDetailDto
{
    public Guid Id { get; set; }
    public int Amount { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Catogery { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }
}
