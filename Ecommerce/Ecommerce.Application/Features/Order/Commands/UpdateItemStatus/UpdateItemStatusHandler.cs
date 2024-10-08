using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.UpdateItemStatus;

public class UpdateItemStatusHandler : IRequestHandler<UpdateItemStatusCommand, ItemsDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public UpdateItemStatusHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<ItemsDto> Handle(UpdateItemStatusCommand request, CancellationToken cancellationToken)
    {

        // Add to database
        var itema = await _orderRepository.UpdateItemStatus(request.id);

        var data = _mapper.Map<ItemsDto>(itema);

        // Return record id
        return data;
    }
}

