using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;

public class GetOrderCancelationDetailHandler : IRequestHandler<GetOrderCancelationDetailsQuery, OrderCancelationDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IOrderCancelationRepository _orderCancelationRepository;

    public GetOrderCancelationDetailHandler(IMapper mapper, IOrderCancelationRepository orderCancelationRepository)
    {
        this._mapper = mapper;
        this._orderCancelationRepository = orderCancelationRepository;

    }


    public async Task<OrderCancelationDetailDto> Handle(GetOrderCancelationDetailsQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categoriesDetails = await _orderCancelationRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        //convert data object to DTO objects
        var data = _mapper.Map<OrderCancelationDetailDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}
