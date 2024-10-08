// ====================================================
// File: UpdateOrderCancellationHandler.cs
// Description: Handler for updating an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order cancellation operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.OrderCancellation.Commands.UpdateOrderCancellation;

public class UpdateOrderCancellationHandler : IRequestHandler<UpdateOrderCancellationCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderCancelationRepository _OrderCancellationRepository; // Repository for order cancellation operations

    public UpdateOrderCancellationHandler(IMapper mapper, IOrderCancelationRepository OrderCancellationRepository)
    {
        this._mapper = mapper;
        this._OrderCancellationRepository = OrderCancellationRepository;
    }

    public async Task<Guid> Handle(UpdateOrderCancellationCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data

        // Convert domain entity object
        var OrderCancellationToUpdate = _mapper.Map<Domain.OrderCancelation>(request.dto);

        // Add to database
        await _OrderCancellationRepository.UpdateAsync(OrderCancellationToUpdate);

        // Return record id
        return OrderCancellationToUpdate.Id;
    }
}
