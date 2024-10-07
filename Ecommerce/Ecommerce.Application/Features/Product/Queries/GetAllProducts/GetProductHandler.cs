using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetAllProducts;


public class GetProductHandler : IRequestHandler<GetProductQuery, List<ProductDto>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;
    private readonly IVendorFeedbackRepository _vendorRepository;

    public GetProductHandler(IMapper mapper, IProductRepository productRepository, IVendorFeedbackRepository vendorRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;
        this._vendorRepository = vendorRepository;

    }

    public async Task<List<ProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var products = await _productRepository.GetAsync();

        var data = _mapper.Map<List<ProductDto>>(products);

        // Return list of DTO objects
        return data;
    }


}
