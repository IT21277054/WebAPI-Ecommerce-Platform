﻿// ====================================================
// File: GetByVendorIdHandler.cs
// Description: Handler for retrieving products by vendor ID using MediatR.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetByVendorId;

public class GetByVendorIdHandler : IRequestHandler<GetByVendorIdQuery, List<ProductDetailDto>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public GetByVendorIdHandler(IMapper mapper, IProductRepository productRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;
    }

    public async Task<List<ProductDetailDto>> Handle(GetByVendorIdQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var categoriesDetails = await _productRepository.GetByVendorId(request.Id);

        // Validate incoming data

        // Convert data object to DTO objects
        var data = _mapper.Map<List<ProductDetailDto>>(categoriesDetails);

        // Return list of DTO objects
        return data;
    }
}
