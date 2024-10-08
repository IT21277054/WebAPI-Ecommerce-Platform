// ====================================================
// File: CreateProductCancellationHandler.cs
// Description: Handler for creating an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order cancellation operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public class CreateProductCancellationHandler : IRequestHandler<CreateOrderCancellationCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderCancelationRepository _orderCancellationRepository; // Repository for order cancellation operations

    public CreateProductCancellationHandler(IMapper mapper, IOrderCancelationRepository orderCancellationRepository)
    {
        this._mapper = mapper;
        this._orderCancellationRepository = orderCancellationRepository;
    }

    public async Task<Guid> Handle(CreateOrderCancellationCommand request, CancellationToken cancellationToken)
    {
        // Convert domain entity object
        var OrderCancellationToCreate = _mapper.Map<Domain.OrderCancelation>(request.dto);

        OrderCancellationToCreate.Id = Guid.NewGuid();

        // Add to database
        await _orderCancellationRepository.CreateAsync(OrderCancellationToCreate);

        // Return record id
        return OrderCancellationToCreate.Id;
    }
}
