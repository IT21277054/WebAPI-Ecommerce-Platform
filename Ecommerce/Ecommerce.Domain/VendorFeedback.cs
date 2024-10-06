using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class VendorFeedback : IBaseEntity
{
    public string Email { get; set; } = string.Empty;
    public int ProductId { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int Rating { get; set; }

}
