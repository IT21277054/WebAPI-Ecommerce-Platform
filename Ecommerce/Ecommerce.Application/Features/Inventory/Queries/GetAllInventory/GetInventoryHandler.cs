// ====================================================
// File: GetInventoryHandler.cs
// Description: Handler for retrieving all inventory items.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;

public class GetInventoryHandler : IRequestHandler<GetInventoryQuery, List<InventoryDto>>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IInventoryRepository _inventoryRepository; // Repository for inventory operations

    public GetInventoryHandler(IMapper mapper, IInventoryRepository inventoryRepository)
    {
        this._mapper = mapper;
        this._inventoryRepository = inventoryRepository;
    }

    public async Task<List<InventoryDto>> Handle(GetInventoryQuery request, CancellationToken cancellationToken)
    {
        // Query the database for all inventory items
        var inventoryItems = await _inventoryRepository.GetAsync();

        // Convert the inventory items to DTO objects
        var data = _mapper.Map<List<InventoryDto>>(inventoryItems);

        // Return the list of DTO objects
        return data;
    }
}
