// ====================================================
// File: GetCartHandler.cs
// Description: Handler for fetching cart details by ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;

// Handler for retrieving details of a specific cart
public class GetCartHandler : IRequestHandler<GetCartDetailsQuery, CartDetailDto>
{
    private readonly IMapper _mapper; // AutoMapper for mapping objects
    private readonly ICartRepository _cartRepository; // Repository for category operations

    public GetCartHandler(IMapper mapper, ICartRepository categoryRepository)
    {
        this._mapper = mapper;
        this._cartRepository = categoryRepository;
    }

    public async Task<CartDetailDto> Handle(GetCartDetailsQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var categoriesDetails = await _cartRepository.GetCartByEmail(request.Email);

        // Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Email);
        }

        // Return DTO object
        return categoriesDetails;

    }
}
