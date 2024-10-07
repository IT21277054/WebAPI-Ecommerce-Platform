using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Cart : BaseEntity<Guid>
{
    public ICollection<CartItem> Items { get; set; }
    public string UserId { get; set; }
}