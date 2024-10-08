using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Queries.GetProductByCategory;

public class GetProductByCategoryHandler : IRequestHandler<GetProductByCategoryQuery, List<ProductDto>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public GetProductByCategoryHandler(IMapper mapper, IProductRepository productRepository, IVendorFeedbackRepository vendorRepository)
    {
        // Initializes the handler with dependencies for mapping, product repository, and vendor feedback repository
        this._mapper = mapper;
        this._productRepository = productRepository;
    }

    public async Task<List<ProductDto>> Handle(GetProductByCategoryQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var products = await _productRepository.GetByCategoryId(request.catogery);

        // Convert the data to DTO objects
        var data = _mapper.Map<List<ProductDto>>(products);

        // Return list of DTO objects
        return data;
    }
}