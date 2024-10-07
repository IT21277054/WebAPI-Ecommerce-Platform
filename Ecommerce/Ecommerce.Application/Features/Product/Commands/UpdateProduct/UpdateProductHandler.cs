using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Product.Commands.UpdateProduct;

public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public UpdateProductHandler(IMapper mapper, IProductRepository productRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;

    }
    public async Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var ProductToUpdate = _mapper.Map<Domain.Product>(request.dto);

        //add to database
        await _productRepository.UpdateAsync(ProductToUpdate);

        //return record id
        return ProductToUpdate.Id;
    }
}
