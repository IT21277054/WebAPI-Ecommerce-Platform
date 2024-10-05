using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;

public record DeleteVendorFeedbackCommand(int Id) : IRequest<Unit>;
