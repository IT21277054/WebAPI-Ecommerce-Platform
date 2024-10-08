// ====================================================
// File: UpdateInventoryHandler.cs
// Description: Handler for updating an inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.UpdateInventory;

public class UpdateInventoryHandler : IRequestHandler<UpdateInventoryCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IInventoryRepository _InventoryRepository; // Repository for inventory operations

    public UpdateInventoryHandler(IMapper mapper, IInventoryRepository InventoryRepository)
    {
        this._mapper = mapper;
        this._InventoryRepository = InventoryRepository;
    }

    public async Task<Guid> Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data (optional validation can be added here)

        // Convert DTO to domain entity
        var InventoryToUpdate = _mapper.Map<Domain.Inventory>(request.dto);

        // Update the inventory item in the database
        await _InventoryRepository.UpdateAsync(InventoryToUpdate);

        // Return the updated record's ID
        return InventoryToUpdate.Id;
    }
}
