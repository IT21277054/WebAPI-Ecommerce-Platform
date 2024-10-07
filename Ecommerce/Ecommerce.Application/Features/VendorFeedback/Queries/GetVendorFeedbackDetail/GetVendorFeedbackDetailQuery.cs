using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;

public record GetVendorFeedbackDetailQuery(Guid Id) : IRequest<VendorFeedbackDetailDto>;