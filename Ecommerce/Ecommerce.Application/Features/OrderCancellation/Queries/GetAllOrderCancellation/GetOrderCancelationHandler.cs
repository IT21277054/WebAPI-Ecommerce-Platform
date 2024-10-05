using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;

public class GetOrderCancelationHandler : IRequestHandler<GetOrderCancelationQuery, List<OrderCancelationDto>>
{
    private readonly IMapper _mapper;
    private readonly IOrderCancelationRepository _orderCancelationRepository;

    public GetOrderCancelationHandler(IMapper mapper, IOrderCancelationRepository orderCancelationRepository)
    {
        this._mapper = mapper;
        this._orderCancelationRepository = orderCancelationRepository;

    }

    public async Task<List<OrderCancelationDto>> Handle(GetOrderCancelationQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _orderCancelationRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<OrderCancelationDto>>(categories);

        //return list of Dto objects
        return data;
    }
}