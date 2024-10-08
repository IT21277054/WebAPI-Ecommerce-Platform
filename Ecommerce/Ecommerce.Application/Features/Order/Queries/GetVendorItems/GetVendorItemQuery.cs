using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetVendorItems;

public record GetVendorItemQuery(Guid VendorId) : IRequest<ItemsDto>;