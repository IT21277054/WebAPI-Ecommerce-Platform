// ====================================================
// File: DeleteProductHandler.cs
// Description: Handler for deleting a product based on the provided command.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
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
        // Retrieve the product to delete using the repository
        var ProductToDelete = await _productRepository.GetByIdAsync(request.Id);

        // Validate incoming data 

        // Delete the product from the database
        await _productRepository.DeleteAsync(ProductToDelete);

        // Return confirmation of the delete operation
        return Unit.Value;
    }
}
