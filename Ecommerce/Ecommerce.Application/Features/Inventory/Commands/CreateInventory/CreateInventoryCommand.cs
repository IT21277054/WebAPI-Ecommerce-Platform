using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory;

public record CreateInventoryCommand(InventoryDto dto) : IRequest<int>;