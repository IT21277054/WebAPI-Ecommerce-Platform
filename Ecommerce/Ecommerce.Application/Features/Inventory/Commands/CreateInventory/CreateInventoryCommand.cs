using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory;

public record CreateInventoryCommand(CreateInventoryDto dto) : IRequest<Guid>;