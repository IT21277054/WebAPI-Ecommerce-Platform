using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.UpdateInventory;

public class UpdateInventoryHandler : IRequestHandler<UpdateInventoryCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IInventoryRepository _InventoryRepository;

    public UpdateInventoryHandler(IMapper mapper, IInventoryRepository InventoryRepository)
    {
        this._mapper = mapper;
        this._InventoryRepository = InventoryRepository;

    }
    public async Task<Guid> Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var InventoryToUpdate = _mapper.Map<Domain.Inventory>(request.dto);

        //add to database
        await _InventoryRepository.UpdateAsync(InventoryToUpdate);

        //return record id
        return InventoryToUpdate.Id;
    }
}