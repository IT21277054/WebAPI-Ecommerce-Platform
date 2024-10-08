// ====================================================
// File: GetVendorFeedbackQuery.cs
// Description: Query for retrieving all vendor feedbacks.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;

public record GetVendorFeedbackQuery : IRequest<List<VendorFeedbackDto>>;