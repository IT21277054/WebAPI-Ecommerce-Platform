// ====================================================
// File: GetInventoryDetailHandler.cs
// Description: Handler for retrieving inventory item details.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for inventory operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;

public class GetInventoryDetailHandler : IRequestHandler<GetInventoryDetailQuery, InventoryDetailDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IInventoryRepository _iInventoryRepository; // Repository for inventory operations

    public GetInventoryDetailHandler(IMapper mapper, IInventoryRepository iInventoryRepository)
    {
        this._mapper = mapper;
        this._iInventoryRepository = iInventoryRepository;
    }

    public async Task<InventoryDetailDto> Handle(GetInventoryDetailQuery request, CancellationToken cancellationToken)
    {
        // Query the database for inventory item details
        var categoriesDetails = await _iInventoryRepository.GetByIdAsync(request.Id);

        // Validate incoming data (to be implemented)

        // Convert data object to DTO object
        var data = _mapper.Map<InventoryDetailDto>(categoriesDetails);

        // Return the DTO object
        return data;
    }
}
