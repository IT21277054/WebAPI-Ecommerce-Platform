using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class VendorFeedback : BaseEntity<Guid>
{
    public string Email { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int rating { get; set; }

}
