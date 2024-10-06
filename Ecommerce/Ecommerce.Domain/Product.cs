using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Product : IBaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string VendorId { get; set; } = string.Empty;
    public bool IsActivated { get; set; }

}
