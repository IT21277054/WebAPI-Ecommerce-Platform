using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Order.Queries.GetVendorItems;
using Ecommerce.Domain;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.UpdateItemWithItemId;

public class UpdateItemHandler : IRequestHandler<UpdateItemCommand, GetVendorItemDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public UpdateItemHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<GetVendorItemDto> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data (to be implemented)

        // Convert domain entity object
        var OrderToUpdate = _mapper.Map<Items>(request.dto);

        // Add to database
        var updatedItem = await _orderRepository.UpdateItemsByItemId(OrderToUpdate);

        var mappedItems = _mapper.Map<GetVendorItemDto>(updatedItem);
        // Return record id
        return mappedItems;
    }
}
