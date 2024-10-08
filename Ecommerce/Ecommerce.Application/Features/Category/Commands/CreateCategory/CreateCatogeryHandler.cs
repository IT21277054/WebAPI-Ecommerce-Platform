// ====================================================
// File: CreateCategoryHandler.cs
// Description: Handler for creating a new category.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory;

// Handler for processing CreateCategoryCommand
public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, int>
{
    private readonly IMapper _mapper; // Mapper for object-to-object mapping
    private readonly ICategoryRepository _categoryRepository; // Repository for category operations

    public CreateCategoryHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;
    }

    public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        // Convert the incoming DTO to the domain entity
        var categoryToCreate = _mapper.Map<Domain.Category>(request.dto);

        // Get the last category ID from the database
        var lastCategory = await _categoryRepository.GetLastCategoryAsync();
        categoryToCreate.Id = (lastCategory != null) ? lastCategory.Id + 1 : 1; // Set new ID

        // Add the new category to the database
        await _categoryRepository.CreateAsync(categoryToCreate);

        // Return the ID of the newly created category
        return categoryToCreate.Id;
    }
}
