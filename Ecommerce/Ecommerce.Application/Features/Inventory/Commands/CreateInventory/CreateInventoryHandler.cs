using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory;

public class CreateInventoryHandler : IRequestHandler<CreateInventoryCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IInventoryRepository _inventoryRepository;

    public CreateInventoryHandler(IMapper mapper, IInventoryRepository inventoryRepository)
    {
        this._mapper = mapper;
        this._inventoryRepository = inventoryRepository;

    }
    public async Task<Guid> Handle(CreateInventoryCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var InventoryToCreate = _mapper.Map<Domain.Inventory>(request.dto);

        InventoryToCreate.Id = Guid.NewGuid();

        //add to database
        await _inventoryRepository.CreateAsync(InventoryToCreate);

        //return record id
        return InventoryToCreate.Id;
    }
}
