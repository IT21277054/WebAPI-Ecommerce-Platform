using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IOrderRepository _orderRepository;

    public CreateOrderHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;

    }
    public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var OrderToCreate = _mapper.Map<Domain.Order>(request.dto);

        OrderToCreate.Id = Guid.NewGuid();

        //add to database
        await _orderRepository.CreateAsync(OrderToCreate);

        //return record id
        return OrderToCreate.Id;
    }
}
