using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public record CreateVendorCommand(VendorDto dto) : IRequest<int>;
