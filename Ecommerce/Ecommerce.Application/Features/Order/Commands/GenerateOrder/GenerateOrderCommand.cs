using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.GenerateOrder;

public class GenerateOrderCommand : IRequestHandler<GenerateOrderHandler, OrderDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public GenerateOrderCommand(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<OrderDto> Handle(GenerateOrderHandler request, CancellationToken cancellationToken)
    {

        // Add to database
        var generatedOrder = await _orderRepository.GenerateOrder(request.email);

        // Convert domain entity object
        var mappedItems = _mapper.Map<OrderDto>(generatedOrder);

        // Return record id
        return mappedItems;
    }
}