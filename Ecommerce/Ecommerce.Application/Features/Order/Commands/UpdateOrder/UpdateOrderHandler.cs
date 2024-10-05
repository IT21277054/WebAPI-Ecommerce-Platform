using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.UpdateOrder;

public class UpdateOrderHandler : IRequestHandler<UpdateOrderCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IOrderRepository _orderRepository;

    public UpdateOrderHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;

    }
    public async Task<int> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var OrderToUpdate = _mapper.Map<Domain.Order>(request.dto);

        //add to database
        await _orderRepository.UpdateAsync(OrderToUpdate);

        //return record id
        return OrderToUpdate.Id;
    }
}