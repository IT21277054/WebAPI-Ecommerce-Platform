// ====================================================
// File: CreateInventoryHandler.cs
// Description: Handler for creating a new inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory;

// Handler for creating a new inventory item
public class CreateInventoryHandler : IRequestHandler<CreateInventoryCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for mapping DTO to domain entity
    private readonly IInventoryRepository _inventoryRepository; // Repository for inventory operations

    public CreateInventoryHandler(IMapper mapper, IInventoryRepository inventoryRepository)
    {
        this._mapper = mapper;
        this._inventoryRepository = inventoryRepository;
    }

    public async Task<Guid> Handle(CreateInventoryCommand request, CancellationToken cancellationToken)
    {
        // Convert the incoming DTO to the domain entity
        var inventoryToCreate = _mapper.Map<Domain.Inventory>(request.dto);

        inventoryToCreate.Id = Guid.NewGuid(); // Assign a new unique ID

        // Add the new inventory item to the database
        await _inventoryRepository.CreateAsync(inventoryToCreate);

        // Return the ID of the created inventory item
        return inventoryToCreate.Id;
    }
}
