using MediatR;

namespace Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;

public record GetCategoryDetailsQuery(int Id) : IRequest<CatgoryDetailsDto>;
