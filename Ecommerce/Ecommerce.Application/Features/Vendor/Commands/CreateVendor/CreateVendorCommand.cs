// ====================================================
// File: CreateVendorCommand.cs
// Description: Represents a command for creating a new vendor.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public record CreateVendorCommand(CreateVendorDto dto) : IRequest<Guid>;