using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;

public class GetOrderDetailHandler : IRequestHandler<GetOrderDetailQuery, OrderDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IOrderRepository _orderRepository;

    public GetOrderDetailHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;

    }


    public async Task<OrderDetailDto> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categoriesDetails = await _orderRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        //convert data object to DTO objects
        var data = _mapper.Map<OrderDetailDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}
