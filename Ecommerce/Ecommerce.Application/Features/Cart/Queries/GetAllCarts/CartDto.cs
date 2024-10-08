// ====================================================
// File: CartDto.cs
// Description: Data transfer object for Cart, used for transferring cart data between layers.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

public class CartDto
{
    public Guid Id { get; set; }
    public Guid[] Product { get; set; } = Array.Empty<Guid>();
    public Guid? UserId { get; set; }
    public string Email { get; set; }
}
