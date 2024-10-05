using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;

public class GetInventoryHandler : IRequestHandler<GetInventoryQuery, List<InventoryDto>>
{
    private readonly IMapper _mapper;
    private readonly IInventoryRepository _inventoryRepository;

    public GetInventoryHandler(IMapper mapper, IInventoryRepository inventoryRepository)
    {
        this._mapper = mapper;
        this._inventoryRepository = inventoryRepository;

    }

    public async Task<List<InventoryDto>> Handle(GetInventoryQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _inventoryRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<InventoryDto>>(categories);

        //return list of Dto objects
        return data;
    }
}