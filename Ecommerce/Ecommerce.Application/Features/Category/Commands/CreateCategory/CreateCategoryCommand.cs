using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory;

public record CreateCategoryCommand(CreateCategoryDto dto) : IRequest<int>;
