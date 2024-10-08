// ====================================================
// File: DeleteVendorFeedbackCommand.cs
// Description: Represents a command for deleting a vendor feedback by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;

public record DeleteVendorFeedbackCommand(Guid Id) : IRequest<Unit>;