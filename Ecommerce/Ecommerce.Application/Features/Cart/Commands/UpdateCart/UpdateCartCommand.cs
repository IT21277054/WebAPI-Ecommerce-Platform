using Ecommerce.Application.Features.Cart.Queries.GetAllCarts;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.UpdateCart;

public record UpdateCartCommand(CartDto dto) : IRequest<Guid>;