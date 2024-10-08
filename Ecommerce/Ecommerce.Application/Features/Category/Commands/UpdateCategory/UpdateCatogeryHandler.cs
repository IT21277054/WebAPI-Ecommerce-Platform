// ====================================================
// File: UpdateCategoryHandler.cs
// Description: Handler for updating a category in the database.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.UpdateCategory;

// Handler for updating a category
public class UpdateCatogeryHandler : IRequestHandler<UpdateCategoryCommand, int>
{
    private readonly IMapper _mapper; // AutoMapper for mapping DTOs to domain entities
    private readonly ICategoryRepository _categoryRepository; // Repository for category operations

    public UpdateCatogeryHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;
    }

    public async Task<int> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data

        // Convert DTO to domain entity object
        var categoryToUpdate = _mapper.Map<Domain.Category>(request.dto);

        // Update the category in the database
        await _categoryRepository.UpdateAsync(categoryToUpdate);

        // Return the record ID
        return categoryToUpdate.Id;
    }
}
