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
        //Query the database
        var categoriesDetails = await _productRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        //convert data object to DTO objects
        var data = _mapper.Map<ProductDetailDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}
