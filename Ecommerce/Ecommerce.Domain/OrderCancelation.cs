using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class OrderCancelation : IBaseEntity
{
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public int OrderId { get; set; }

}
