using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;


public record GetCartDetailsQuery(Guid Id) : IRequest<CartDetailDto>;

