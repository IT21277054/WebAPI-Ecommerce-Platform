// ====================================================
// File: DeleteCartHandler.cs
// Description: Handler for deleting a cart by its ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.DeleteCart;

// Handler for deleting a cart
public class DeleteCartHandler : IRequestHandler<DeleteCartCommand, Unit>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly ICartRepository _cartRepository; // Repository for cart operations

    public DeleteCartHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;
    }

    public async Task<Unit> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the cart entity to delete
        var cartToDelete = await _cartRepository.GetByIdAsync(request.Id);

        // Validate if the cart exists (optional)

        // Delete the cart from the database
        await _cartRepository.DeleteAsync(cartToDelete);

        // Return a success response
        return Unit.Value;
    }
}
