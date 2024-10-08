// ====================================================
// File: UpdateProductHandler.cs
// Description: Handler for processing the update of a product using the provided command and data transfer object (DTO).
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

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
        // Validate incoming data (implement validation logic here)

        // Convert command DTO to domain entity object
        var ProductToUpdate = _mapper.Map<Domain.Product>(request.dto);

        // Update the product in the database
        await _productRepository.UpdateAsync(ProductToUpdate);

        // Return the ID of the updated product
        return ProductToUpdate.Id;
    }
}
