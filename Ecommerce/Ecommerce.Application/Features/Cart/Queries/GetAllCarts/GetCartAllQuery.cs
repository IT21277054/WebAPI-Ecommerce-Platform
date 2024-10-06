using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetAllCarts;

public record GetCartAllQuery : IRequest<List<CartDto>>;