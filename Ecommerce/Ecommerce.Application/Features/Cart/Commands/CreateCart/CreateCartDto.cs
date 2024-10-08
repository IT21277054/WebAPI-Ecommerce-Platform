// ====================================================
// File: CreateCartDto.cs
// Description: Data Transfer Object for creating a cart entity.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart;

// Data Transfer Object for creating a new Cart
public class CreateCartDto
{
    public ProductDto[] Product { get; set; } = Array.Empty<ProductDto>();
    public Guid UserId { get; set; }
}
