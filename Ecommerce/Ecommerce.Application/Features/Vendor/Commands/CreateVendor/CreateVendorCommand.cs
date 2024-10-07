using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public record CreateVendorCommand(CreateVendorDto dto) : IRequest<Guid>;
