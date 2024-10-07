using Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.UpdateAddVendorFeedback;

public record UpdateVendorFeedbackCommand(VendorFeedbackDto dto) : IRequest<Guid>;
