using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;
using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetOrderByEmail;


public class GetOrderByEmailHandler : IRequestHandler<GetOrderByEmailQuery, OrderDetailDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public GetOrderByEmailHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<OrderDetailDto> Handle(GetOrderByEmailQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var orderDetails = await _orderRepository.GetOrderByEmail(request.email);

        // Validate incoming data
        if (orderDetails == null)
        {
            throw new NotFoundException(nameof(Order), request.email);
        }

        // Convert data object to DTO objects
        var data = _mapper.Map<OrderDetailDto>(orderDetails);

        // Return list of DTO objects
        return data;
    }
}