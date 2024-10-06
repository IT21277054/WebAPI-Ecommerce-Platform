using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

public class GetCartAllHandler : IRequestHandler<GetCartAllQuery, List<CartDto>>
{
    private readonly IMapper _mapper;
    private readonly ICartRepository _cartRepository;

    public GetCartAllHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;

    }

    public async Task<List<CartDto>> Handle(GetCartAllQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var cart = await _cartRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<CartDto>>(cart);

        //return list of Dto objects
        return data;
    }
}