using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetAllOrders;

public class GetOrderHandler : IRequestHandler<GetOrderQuery, List<OrderDto>>
{
    private readonly IMapper _mapper;
    private readonly IOrderRepository _orderyRepository;

    public GetOrderHandler(IMapper mapper, IOrderRepository orderyRepository)
    {
        this._mapper = mapper;
        this._orderyRepository = orderyRepository;

    }

    public async Task<List<OrderDto>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _orderyRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<OrderDto>>(categories);

        //return list of Dto objects
        return data;
    }
}