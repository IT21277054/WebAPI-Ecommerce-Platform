using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Product.Commands.DeleteProduct;

public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public DeleteProductHandler(IMapper mapper, IProductRepository productRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;

    }

    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var ProductToDelete = await _productRepository.GetByIdAsync(request.Id);

        //Validate incoming data

        //add to database
        await _productRepository.DeleteAsync(ProductToDelete);

        //return record id
        return Unit.Value;
    }
}

