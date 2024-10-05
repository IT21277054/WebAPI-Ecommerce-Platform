using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;

public record DeleteVendorCommand(int Id) : IRequest<Unit>;