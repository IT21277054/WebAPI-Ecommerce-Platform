// ====================================================
// File: CreateVendorFeedbackCommand.cs
// Description: Represents a command for creating a new vendor feedback.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;

public record CreateVendorFeedbackCommand(CreateVendorFeedbackDto dto) : IRequest<Guid>;