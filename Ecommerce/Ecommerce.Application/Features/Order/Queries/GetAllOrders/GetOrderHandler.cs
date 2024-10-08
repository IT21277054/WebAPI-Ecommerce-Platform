// ====================================================
// File: GetOrderHandler.cs
// Description: Handler for retrieving all orders.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order operations
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Queries.GetAllOrders;

public class GetOrderHandler : IRequestHandler<GetOrderQuery, List<OrderDto>>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderyRepository; // Repository for order operations

    public GetOrderHandler(IMapper mapper, IOrderRepository orderyRepository)
    {
        this._mapper = mapper;
        this._orderyRepository = orderyRepository;
    }

    public async Task<List<OrderDto>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var categories = await _orderyRepository.GetAsync();

        // Convert data object to DTO objects
        var data = _mapper.Map<List<OrderDto>>(categories);

        // Return list of DTO objects
        return data;
    }
}
