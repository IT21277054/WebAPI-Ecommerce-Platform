using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;

public record DeleteVendorFeedbackCommand(Guid Id) : IRequest<Unit>;
