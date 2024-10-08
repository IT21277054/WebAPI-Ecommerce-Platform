// ====================================================
// File: UpdateVendorCommand.cs
// Description: Represents a command for updating a vendor.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.UpdateVendor;

public record UpdateVendorCommand(VendorDto dto) : IRequest<Guid>;