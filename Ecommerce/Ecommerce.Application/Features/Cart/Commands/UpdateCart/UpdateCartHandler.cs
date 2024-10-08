// ====================================================
// File: UpdateCartHandler.cs
// Description: Handler for updating an existing cart in the database.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Cart.Queries.GetAllCarts;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.UpdateCart;

public class UpdateCartHandler : IRequestHandler<UpdateCartCommand, CartDto>
{
    private readonly IMapper _mapper; // AutoMapper for mapping DTO to domain entity
    private readonly ICartRepository _cartRepository; // Repository for cart operations

    public UpdateCartHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;
    }

    public async Task<CartDto> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
    {

        // Convert the incoming DTO to the domain entity
        var productToUpdate = _mapper.Map<Domain.Product>(request.dto);

        // Update the cart in the database
        var cartToUpdate = await _cartRepository.UpdateCart(request.email, productToUpdate);

        var updatedCart = _mapper.Map<CartDto>(cartToUpdate);

        // Return the ID of the updated cart
        return updatedCart;
    }
}
