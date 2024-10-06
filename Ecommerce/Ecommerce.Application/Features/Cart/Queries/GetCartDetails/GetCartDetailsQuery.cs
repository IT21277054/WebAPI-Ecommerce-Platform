using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;


public record GetCartDetailsQuery(int Id) : IRequest<CartDetailDto>;

