using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Inventory : BaseEntity<Guid>
{
    public double Amount { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Catogery { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }
}
