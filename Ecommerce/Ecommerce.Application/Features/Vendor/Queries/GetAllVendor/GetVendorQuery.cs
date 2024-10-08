// ====================================================
// File: GetVendorQuery.cs
// Description: Represents a query for retrieving all vendors.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;

public record GetVendorQuery : IRequest<List<VendorDto>>;