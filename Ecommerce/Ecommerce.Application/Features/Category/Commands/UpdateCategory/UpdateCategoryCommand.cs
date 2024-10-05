using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.UpdateCategory;

public record UpdateCategoryCommand(CategoryDto dto) : IRequest<int>;
