// ====================================================
// File: DeleteOrderHandler.cs
// Description: Handler for deleting an order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Commands.DeleteOrder;

public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommand, Unit>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public DeleteOrderHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        // Retrieve domain entity object
        var OrderToDelete = await _orderRepository.GetByIdAsync(request.Id);

        // Validate incoming data (to be implemented)

        // Add to database
        await _orderRepository.DeleteAsync(OrderToDelete);

        // Return record id
        return Unit.Value;
    }
}
