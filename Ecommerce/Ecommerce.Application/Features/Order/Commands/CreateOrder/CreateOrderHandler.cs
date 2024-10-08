// ====================================================
// File: CreateOrderHandler.cs
// Description: Handler for creating a new order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public CreateOrderHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        // Convert domain entity object
        var OrderToCreate = _mapper.Map<Domain.Order>(request.dto);

        OrderToCreate.Id = Guid.NewGuid();

        // Add to database
        await _orderRepository.CreateAsync(OrderToCreate);

        // Return record id
        return OrderToCreate.Id;
    }
}
