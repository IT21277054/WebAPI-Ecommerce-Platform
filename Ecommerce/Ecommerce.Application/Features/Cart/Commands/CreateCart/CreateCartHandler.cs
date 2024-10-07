using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart;

public class CreateCartHandler : IRequestHandler<CreateCartCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly ICartRepository _cartRepository;

    public CreateCartHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;

    }
    public async Task<Guid> Handle(CreateCartCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var cartToCreate = _mapper.Map<Domain.Cart>(request.dto);

        cartToCreate.Id = Guid.NewGuid();

        //add to database
        await _cartRepository.CreateAsync(cartToCreate);

        //return record id
        return cartToCreate.Id;
    }
}