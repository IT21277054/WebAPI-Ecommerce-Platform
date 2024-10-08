// ====================================================
// File: CreateProductHandler.cs
// Description: Handler for creating a new product through commands.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    // Constructor to initialize dependencies
    public CreateProductHandler(IMapper mapper, IProductRepository productRepository)
    {
        this._mapper = mapper; // Assign the mapper for DTO to domain object mapping
        this._productRepository = productRepository; // Assign the product repository for database operations
    }

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Convert domain entity object
        var ProductToCreate = _mapper.Map<Domain.Product>(request.dto);

        ProductToCreate.Id = Guid.NewGuid();

        // Add to database
        await _productRepository.CreateAsync(ProductToCreate);

        // Return record id
        return ProductToCreate.Id;
    }
}
