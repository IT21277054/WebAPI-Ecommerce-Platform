using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;

public record DeleteVendorCommand(Guid Id) : IRequest<Unit>;