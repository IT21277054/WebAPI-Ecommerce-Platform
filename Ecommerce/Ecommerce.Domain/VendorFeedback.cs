using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class VendorFeedback : BaseEntity<Guid>
{

    public string Title { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public int Rating { get; set; }
    public Guid VendorId { get; set; }

}
