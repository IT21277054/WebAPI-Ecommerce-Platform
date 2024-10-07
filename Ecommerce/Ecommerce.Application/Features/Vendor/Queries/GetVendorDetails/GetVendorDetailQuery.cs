using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetails;

public record GetVendorDetailQuery(Guid Id) : IRequest<VendorDetailDto>;