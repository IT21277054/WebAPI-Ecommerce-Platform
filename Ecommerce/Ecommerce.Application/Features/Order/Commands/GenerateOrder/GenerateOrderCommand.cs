using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.GenerateOrder;

public class GenerateOrderCommand : IRequestHandler<CreateOrderCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public GenerateOrderCommand(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        // Convert domain entity object
        var OrderToCreate = _mapper.Map<Domain.Order>(request.dto);

        OrderToCreate.Id = Guid.NewGuid();

        // Loop through items and assign new GUIDs
        foreach (var item in OrderToCreate.Items)
        {
            item.Id = Guid.NewGuid();
        }

        // Add to database
        await _orderRepository.CreateAsync(OrderToCreate);

        // Return record id
        return OrderToCreate.Id;
    }
}