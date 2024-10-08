// ====================================================
// File: CartDetailDto.cs
// Description: Data transfer object for cart details.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Domain;
using Ecommerce.Domain.Common;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;

// DTO for detailed cart information
public class CartDetailDto : BaseEntity<Guid>
{
    public List<ProductDto> Product { get; set; } = new List<ProductDto>();
    public string UserId { get; set; } // User associated with the cart
    public string Email { get; set; }
    public double TotalPrice { get; set; }

}
