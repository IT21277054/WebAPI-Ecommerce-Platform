// ====================================================
// File: GetOrderCancelationHandler.cs
// Description: Handler for retrieving all order cancellations.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order cancellation operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;

public class GetOrderCancelationHandler : IRequestHandler<GetOrderCancelationQuery, List<OrderCancelationDto>>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderCancelationRepository _orderCancelationRepository; // Repository for order cancellation operations

    public GetOrderCancelationHandler(IMapper mapper, IOrderCancelationRepository orderCancelationRepository)
    {
        this._mapper = mapper;
        this._orderCancelationRepository = orderCancelationRepository;
    }

    public async Task<List<OrderCancelationDto>> Handle(GetOrderCancelationQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var categories = await _orderCancelationRepository.GetAsync();

        // Convert data object to DTO objects
        var data = _mapper.Map<List<OrderCancelationDto>>(categories);

        // Return list of Dto objects
        return data;
    }
}
