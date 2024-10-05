using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;

public record GetVendorFeedbackDetailQuery(int Id) : IRequest<VendorFeedbackDetailDto>;