namespace Ecommerce.Domain;

public class CartItem
{
    public string ProductId { get; set; } 

    public Guid Quantity { get; set; }

    public decimal Price { get; set; }
}
