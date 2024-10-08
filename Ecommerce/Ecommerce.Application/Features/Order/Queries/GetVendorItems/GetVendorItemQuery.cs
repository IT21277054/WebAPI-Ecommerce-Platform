using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetVendorItems;

public record GetVendorItemQuery(Guid VendorId) : IRequest<List<GetVendorItemDto>>;