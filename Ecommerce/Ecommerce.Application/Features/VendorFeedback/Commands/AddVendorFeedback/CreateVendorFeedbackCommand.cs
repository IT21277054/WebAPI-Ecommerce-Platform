using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;

public record CreateVendorFeedbackCommand(CreateVendorFeedbackDto dto) : IRequest<Guid>;
