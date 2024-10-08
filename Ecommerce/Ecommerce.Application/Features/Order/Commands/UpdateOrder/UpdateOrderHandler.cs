// ====================================================
// File: UpdateOrderHandler.cs
// Description: Handler for updating an existing order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Commands.UpdateOrder;

public class UpdateOrderHandler : IRequestHandler<UpdateOrderCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public UpdateOrderHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<Guid> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data (to be implemented)

        // Convert domain entity object
        var OrderToUpdate = _mapper.Map<Domain.Order>(request.dto);

        // Add to database
        await _orderRepository.UpdateAsync(OrderToUpdate);

        // Return record id
        return OrderToUpdate.Id;
    }
}
