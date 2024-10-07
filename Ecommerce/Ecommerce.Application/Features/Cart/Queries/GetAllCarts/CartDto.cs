using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

public class CartDto
{
    public Guid Id { get; set; }
    public ICollection<CartItem> Items { get; set; }
    public string UserId { get; set; }
}
