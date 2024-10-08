using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using MediatR;
using System.Collections.Generic;

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
        //Query the database
        var categoriesDetails = await _productRepository.GetByVendorId(request.Id);

        //Validate incoming data

        //convert data object to DTO objects
        var data = _mapper.Map<List<ProductDetailDto>>(categoriesDetails);
        
        //return list of Dto objects
        return data;
    }
}