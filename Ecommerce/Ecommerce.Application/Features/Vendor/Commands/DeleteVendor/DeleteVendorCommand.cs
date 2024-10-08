// ====================================================
// File: DeleteVendorCommand.cs
// Description: Represents a command for deleting a vendor by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;

public record DeleteVendorCommand(Guid Id) : IRequest<Unit>;