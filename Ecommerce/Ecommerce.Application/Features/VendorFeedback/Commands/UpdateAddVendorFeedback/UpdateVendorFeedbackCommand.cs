// ====================================================
// File: UpdateVendorFeedbackCommand.cs
// Description: Command for updating vendor feedback.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.UpdateAddVendorFeedback;

public record UpdateVendorFeedbackCommand(VendorFeedbackDto dto) : IRequest<Guid>;