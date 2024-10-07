using Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;

public record CreateVendorFeedbackCommand(CreateVendorFeedbackDto dto) : IRequest<Guid>;
