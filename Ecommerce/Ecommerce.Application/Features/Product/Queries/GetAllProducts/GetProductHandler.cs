using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetAllProducts;


public class GetProductHandler : IRequestHandler<GetProductQuery, List<ProductDto>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public GetProductHandler(IMapper mapper, IProductRepository productRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;

    }

    public async Task<List<ProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _productRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<ProductDto>>(categories);

        //return list of Dto objects
        return data;
    }
}
