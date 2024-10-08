// ====================================================
// File: GetCartAllHandler.cs
// Description: Handler for retrieving all carts from the database.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

// Handler for getting all carts
public class GetCartAllHandler : IRequestHandler<GetCartAllQuery, List<CartDto>>
{
    private readonly IMapper _mapper; // AutoMapper for mapping domain entities to DTOs
    private readonly ICartRepository _cartRepository; // Repository for cart operations

    public GetCartAllHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;
    }

    public async Task<List<CartDto>> Handle(GetCartAllQuery request, CancellationToken cancellationToken)
    {
        // Query the database for all carts
        var cart = await _cartRepository.GetAsync();

        // Convert the domain entities to DTOs
        var data = _mapper.Map<List<CartDto>>(cart);

        // Return the list of DTO objects
        return data;
    }
}
