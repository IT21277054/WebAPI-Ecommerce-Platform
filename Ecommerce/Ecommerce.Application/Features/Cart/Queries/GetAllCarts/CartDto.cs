using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

public class CartDto
{
    public ICollection<CartItem> Items { get; set; }
    public string UserId { get; set; }
}
