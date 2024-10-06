using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.DeleteInventory;
public class DeleteInventoryHandler : IRequestHandler<DeleteInventoryCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IInventoryRepository _inventoryRepository;

    public DeleteInventoryHandler(IMapper mapper, IInventoryRepository inventoryRepository)
    {
        this._mapper = mapper;
        this._inventoryRepository = inventoryRepository;

    }

    public async Task<Unit> Handle(DeleteInventoryCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var InventoryToDelete = await _inventoryRepository.GetByIdAsync(request.Id);

        //Validate incoming data

        //add to database
        await _inventoryRepository.DeleteAsync(InventoryToDelete);

        //return record id
        return Unit.Value;
    }
}

