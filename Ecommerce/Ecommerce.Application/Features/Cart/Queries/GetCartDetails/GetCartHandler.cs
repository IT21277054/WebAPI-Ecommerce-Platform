// ====================================================
// File: GetCartHandler.cs
// Description: Handler for fetching cart details by ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;

// Handler for retrieving details of a specific cart
public class GetCartHandler : IRequestHandler<GetCartDetailsQuery, CartDetailDto>
{
    private readonly IMapper _mapper; // AutoMapper for mapping objects
    private readonly ICategoryRepository _categoryRepository; // Repository for category operations

    public GetCartHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;
    }

    public async Task<CartDetailDto> Handle(GetCartDetailsQuery request, CancellationToken cancellationToken)
    {
        // Fetch the cart details using the provided ID
        throw new NotFoundException(nameof(Cart), request.Id);

        // Validate incoming data
        // Uncomment and implement validation logic as needed
        // if (categoriesDetails == null)
        // {
        //     throw new NotFoundException(nameof(Cart), request.Id);
        // }

        // Convert data object to DTO objects
        // return _mapper.Map<CartDetailDto>(cartDetails);
    }
}
