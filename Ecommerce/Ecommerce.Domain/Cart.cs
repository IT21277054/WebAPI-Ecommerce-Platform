using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Cart : IBaseEntity
{
    public ICollection<CartItem> Items { get; set; }
    public string UserId { get; set; }
}

public class CartItem
{
    public string ProductId { get; set; } 

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
