// ====================================================
// File: CreateCategoryCommand.cs
// Description: Command to create a new category.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory;

// Command for creating a new category with its DTO
public record CreateCategoryCommand(CreateCategoryDto dto) : IRequest<int>;
