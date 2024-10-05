using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.DeleteCategory;

public record DeleteCategoryCommand(int Id) : IRequest<Unit>;
