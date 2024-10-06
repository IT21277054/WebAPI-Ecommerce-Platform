using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;

public class CartDetailDto
{
    public ICollection<CartItem> Items { get; set; }
    public string UserId { get; set; }
}
