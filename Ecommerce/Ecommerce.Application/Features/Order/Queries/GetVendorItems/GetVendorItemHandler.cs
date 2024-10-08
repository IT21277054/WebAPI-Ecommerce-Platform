using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetVendorItems;

public class GetVendorItemHandler : IRequestHandler<GetVendorItemQuery, ItemsDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public GetVendorItemHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<ItemsDto> Handle(GetVendorItemQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var items = await _orderRepository.GetItemsByVendorId(request.VendorId);

        // Validate incoming data


        // Convert data object to DTO objects
        var data = _mapper.Map<ItemsDto>(items);

        // Return list of DTO objects
        return data;
    }
}
