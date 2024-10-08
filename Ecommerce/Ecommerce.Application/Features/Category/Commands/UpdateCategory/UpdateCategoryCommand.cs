// ====================================================
// File: UpdateCategoryCommand.cs
// Description: Command for updating an existing category.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.UpdateCategory;

// Command to update an existing category
public record UpdateCategoryCommand(CategoryDto dto) : IRequest<int>;
