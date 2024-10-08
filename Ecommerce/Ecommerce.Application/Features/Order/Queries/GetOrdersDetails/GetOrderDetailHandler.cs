// ====================================================
// File: GetOrderDetailHandler.cs
// Description: Handler for retrieving the details of a specific order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper; // AutoMapper for object mapping
using Ecommerce.Application.Contracts.Persistence; // Interface for order operations
using Ecommerce.Application.Exceptions; // Custom exceptions for application errors
using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;

public class GetOrderDetailHandler : IRequestHandler<GetOrderDetailQuery, OrderDetailDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public GetOrderDetailHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<OrderDetailDto> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var categoriesDetails = await _orderRepository.GetByIdAsync(request.Id);

        // Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        // Convert data object to DTO objects
        var data = _mapper.Map<OrderDetailDto>(categoriesDetails);

        // Return list of DTO objects
        return data;
    }
}
