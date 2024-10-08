using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetVendorItems;

public class GetVendorItemHandler : IRequestHandler<GetVendorItemQuery, List<GetVendorItemDto>>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public GetVendorItemHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<List<GetVendorItemDto>> Handle(GetVendorItemQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var items = await _orderRepository.GetItemsByVendorId(request.VendorId);

        // Return list of DTO objects
        return items;
    }
}
