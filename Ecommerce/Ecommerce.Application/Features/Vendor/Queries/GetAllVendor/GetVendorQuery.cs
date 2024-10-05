using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;

public record GetVendorQuery : IRequest<List<VendorDto>>;
