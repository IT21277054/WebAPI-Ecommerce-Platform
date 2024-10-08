// ====================================================
// File: CreateCartHandler.cs
// Description: Handler for creating a cart entity.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart;

// Handler for the CreateCartCommand
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
        // Convert DTO to domain entity object
        var cartToCreate = _mapper.Map<Domain.Cart>(request.dto);

        cartToCreate.Id = Guid.NewGuid();

        // Add to the database
        await _cartRepository.CreateAsync(cartToCreate);

        // Return record ID
        return cartToCreate.Id;
    }
}
