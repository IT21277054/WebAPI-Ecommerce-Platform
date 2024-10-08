// ====================================================
// File: GetCartAllQuery.cs
// Description: Query for retrieving all carts.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

// Query to get all carts
public record GetCartAllQuery : IRequest<List<CartDto>>;
