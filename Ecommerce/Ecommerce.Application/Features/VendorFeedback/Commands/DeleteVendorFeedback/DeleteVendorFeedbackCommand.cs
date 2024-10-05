using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;

public class DeleteVendorFeedbackCommand : IRequest<Unit>
{
    public int Id { get; set; }
}
