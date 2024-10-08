// ====================================================
// File: GetVendorFeedbackDetailQuery.cs
// Description: Query for retrieving a specific vendor feedback by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;

public record GetVendorFeedbackDetailQuery(Guid Id) : IRequest<VendorFeedbackDetailDto>;