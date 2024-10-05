using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetails;

public record GetVendorDetailQuery(int Id) : IRequest<VendorDetailDto>;