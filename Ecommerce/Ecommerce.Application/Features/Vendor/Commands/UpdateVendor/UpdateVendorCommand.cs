using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.UpdateVendor;

public record UpdateVendorCommand(VendorDto dto) : IRequest<Guid>;
