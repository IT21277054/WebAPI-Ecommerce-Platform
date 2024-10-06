using Ecommerce.Application.Features.Cart.Queries.GetAllCarts;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart;

public record CreateCartCommand(CartDto dto) : IRequest<int>;
