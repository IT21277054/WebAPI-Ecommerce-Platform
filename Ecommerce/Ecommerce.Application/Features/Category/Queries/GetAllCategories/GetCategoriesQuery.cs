using MediatR;

namespace Ecommerce.Application.Features.Category.Queries.GetAllCategories;

public record GetCategoriesQuery : IRequest<List<CategoryDto>>;
