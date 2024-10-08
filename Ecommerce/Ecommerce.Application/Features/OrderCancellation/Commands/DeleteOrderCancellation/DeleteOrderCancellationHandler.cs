// ====================================================
// File: DeleteOrderCancellationHandler.cs
// Description: Handler for deleting an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order cancellation operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;

public class DeleteOrderCancellationHandler : IRequestHandler<DeleteOrderCancellationCommand, Unit>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderCancelationRepository _orderCancellationRepository; // Repository for order cancellation operations

    public DeleteOrderCancellationHandler(IMapper mapper, IOrderCancelationRepository orderCancellationRepository)
    {
        this._mapper = mapper;
        this._orderCancellationRepository = orderCancellationRepository;
    }

    public async Task<Unit> Handle(DeleteOrderCancellationCommand request, CancellationToken cancellationToken)
    {
        // Retrieve domain entity object
        var OrderCancellationToDelete = await _orderCancellationRepository.GetByIdAsync(request.Id);

        // Validate incoming data

        // Add to database
        await _orderCancellationRepository.DeleteAsync(OrderCancellationToDelete);

        // Return record id
        return Unit.Value;
    }
}
