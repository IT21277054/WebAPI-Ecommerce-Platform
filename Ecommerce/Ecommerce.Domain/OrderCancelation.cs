using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class OrderCancelation : BaseEntity<Guid>
{
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public Guid OrderId { get; set; }

}
