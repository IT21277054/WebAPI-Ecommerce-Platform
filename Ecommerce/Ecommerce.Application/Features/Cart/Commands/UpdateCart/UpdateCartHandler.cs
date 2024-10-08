// ====================================================
// File: UpdateCartHandler.cs
// Description: Handler for updating an existing cart in the database.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.UpdateCart;

public class UpdateCartHandler : IRequestHandler<UpdateCartCommand, Guid>
{
    private readonly IMapper _mapper; // AutoMapper for mapping DTO to domain entity
    private readonly ICartRepository _cartRepository; // Repository for cart operations

    public UpdateCartHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;
    }

    public async Task<Guid> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data (optional)

        // Convert the incoming DTO to the domain entity
        var cartToUpdate = _mapper.Map<Domain.Cart>(request.dto);

        // Update the cart in the database
        await _cartRepository.UpdateAsync(cartToUpdate);

        // Return the ID of the updated cart
        return cartToUpdate.Id;
    }
}
