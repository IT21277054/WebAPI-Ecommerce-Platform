using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public CreateProductHandler(IMapper mapper, IProductRepository productRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;

    }
    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var ProductToCreate = _mapper.Map<Domain.Product>(request.dto);

        //add to database
        await _productRepository.CreateAsync(ProductToCreate);

        //return record id
        return ProductToCreate.Id;
    }
}
