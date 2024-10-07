using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart;

public class CreateCartDto
{
    public ICollection<CartItem> Items { get; set; }
    public Guid UserId { get; set; }
}
