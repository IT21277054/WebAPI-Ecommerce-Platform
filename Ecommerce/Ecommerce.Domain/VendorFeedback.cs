using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class VendorFeedback : IBaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Rate { get; set; }
    public int VendorId { get; set; }
}
