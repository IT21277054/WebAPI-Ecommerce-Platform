using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.UpdateCart;

public class UpdateCartHandler : IRequestHandler<UpdateCartCommand, int>
{
    private readonly IMapper _mapper;
    private readonly ICartRepository _cartRepository;

    public UpdateCartHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;

    }
    public async Task<int> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var cartToUpdate = _mapper.Map<Domain.Cart>(request.dto);

        //add to database
        await _cartRepository.UpdateAsync(cartToUpdate);

        //return record id
        return cartToUpdate.Id;
    }
}
