// ====================================================
// File: GetProductQuery.cs
// Description: Query for retrieving a list of products as a Data Transfer Object (DTO).
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetAllProducts;

public record GetProductQuery : IRequest<List<ProductDto>>;
