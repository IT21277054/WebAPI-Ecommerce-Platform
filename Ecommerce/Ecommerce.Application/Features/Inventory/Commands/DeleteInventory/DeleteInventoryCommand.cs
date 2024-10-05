using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.DeleteInventory;

public class DeleteInventoryCommand : IRequest<Unit>
{
    public int Id { get; set; }
}