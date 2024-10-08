// ====================================================
// File: GetVendorDetailQuery.cs
// Description: Represents a query for retrieving a specific vendor's details by ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetailQuery; // Corrected Namespace

public record GetVendorDetailQuery(Guid Id) : IRequest<VendorDetailDto>;