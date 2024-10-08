using Ecommerce.Application.Features.Order.Queries.GetVendorItems;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.UpdateItemWithItemId;

// Command for updating an existing order, returning the order's unique identifier
public record UpdateItemCommand(GetVendorItemDto dto) : IRequest<GetVendorItemDto>;
