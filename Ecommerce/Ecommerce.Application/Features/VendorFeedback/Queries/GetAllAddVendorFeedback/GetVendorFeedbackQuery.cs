using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;

public record GetVendorFeedbackQuery : IRequest<List<VendorFeedbackDto>>;