using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.DeleteCart;

public record DeleteCartCommand(Guid Id) : IRequest<Unit>;
