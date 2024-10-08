// ====================================================
// File: GetProductDetailHandler.cs
// Description: Handler for retrieving product details based on product ID using MediatR.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetProductDetails;

public class GetProductDetailHandler : IRequestHandler<GetProductDetailQuery, ProductDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public GetProductDetailHandler(IMapper mapper, IProductRepository productRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;
    }

    public async Task<ProductDetailDto> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var categoriesDetails = await _productRepository.GetByIdAsync(request.Id);

        // Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        // Convert data object to DTO object
        var data = _mapper.Map<ProductDetailDto>(categoriesDetails);

        // Return DTO object
        return data;
    }
}
