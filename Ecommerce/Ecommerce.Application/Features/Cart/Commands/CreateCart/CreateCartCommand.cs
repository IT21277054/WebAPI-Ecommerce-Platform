using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart;

public record CreateCartCommand(CreateCartDto dto) : IRequest<Guid>;
