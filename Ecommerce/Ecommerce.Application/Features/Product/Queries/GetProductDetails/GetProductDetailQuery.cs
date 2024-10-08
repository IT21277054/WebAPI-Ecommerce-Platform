// ====================================================
// File: GetProductDetailQuery.cs
// Description: Query for retrieving product details using the product ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetProductDetails;

public record GetProductDetailQuery(Guid Id) : IRequest<ProductDetailDto>;
