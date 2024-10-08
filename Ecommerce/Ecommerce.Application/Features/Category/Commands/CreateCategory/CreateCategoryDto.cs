// ====================================================
// File: CreateCategoryDto.cs
// Description: Data Transfer Object for creating a new category.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory;

// DTO for creating a new category
public class CreateCategoryDto
{
    public string Name { get; set; } = string.Empty; // Name of the category
}
