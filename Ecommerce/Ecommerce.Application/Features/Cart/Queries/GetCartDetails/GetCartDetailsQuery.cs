// ====================================================
// File: GetCartDetailsQuery.cs
// Description: Query for retrieving cart details by ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;

// Query to fetch details of a specific cart by its ID
public record GetCartDetailsQuery(Guid Id) : IRequest<CartDetailDto>;
