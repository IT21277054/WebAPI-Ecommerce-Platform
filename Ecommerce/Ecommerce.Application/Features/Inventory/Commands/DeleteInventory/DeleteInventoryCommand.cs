using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.DeleteInventory;

public record DeleteInventoryCommand(Guid Id) : IRequest<Unit>;