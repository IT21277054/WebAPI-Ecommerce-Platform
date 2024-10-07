using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.UpdateInventory;

public record UpdateInventoryCommand(InventoryDto dto) : IRequest<Guid>;
