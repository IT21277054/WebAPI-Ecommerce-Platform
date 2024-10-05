using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;


public class GetInventoryDetailHandler : IRequestHandler<GetInventoryDetailQuery, InventoryDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IInventoryRepository _iInventoryRepository;

    public GetInventoryDetailHandler(IMapper mapper, IInventoryRepository iInventoryRepository)
    {
        this._mapper = mapper;
        this._iInventoryRepository = iInventoryRepository;

    }


    public async Task<InventoryDetailDto> Handle(GetInventoryDetailQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categoriesDetails = await _iInventoryRepository.GetByIdAsync(request.Id);

        //Validate incoming data


        //convert data object to DTO objects
        var data = _mapper.Map<InventoryDetailDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}