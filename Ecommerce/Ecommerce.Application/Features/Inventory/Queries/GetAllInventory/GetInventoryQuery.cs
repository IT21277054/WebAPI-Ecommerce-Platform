using MediatR;

namespace Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;

public record GetInventoryQuery : IRequest<List<InventoryDto>>;
