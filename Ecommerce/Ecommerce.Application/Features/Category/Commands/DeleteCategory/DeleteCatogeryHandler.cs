// ====================================================
// File: DeleteCategoryHandler.cs
// Description: Handler for deleting a category by its ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.DeleteCategory;

// Handler for deleting a category
public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, Unit>
{
    private readonly IMapper _mapper; // AutoMapper for mapping objects
    private readonly ICategoryRepository _categoryRepository; // Repository for category operations

    public DeleteCategoryHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;
    }

    public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the category entity to delete
        var categoryToDelete = await _categoryRepository.GetByIdAsync(request.Id);

        // Validate if the category exists (optional)

        // Delete the category from the database
        await _categoryRepository.DeleteAsync(categoryToDelete);

        // Return a success response
        return Unit.Value;
    }
}
