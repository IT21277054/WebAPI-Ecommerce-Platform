// ====================================================
// File: GetByVendorIdQuery.cs
// Description: Query for retrieving a list of product details by vendor ID using MediatR.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetByVendorId;

public record GetByVendorIdQuery(Guid Id) : IRequest<List<ProductDetailDto>>;
