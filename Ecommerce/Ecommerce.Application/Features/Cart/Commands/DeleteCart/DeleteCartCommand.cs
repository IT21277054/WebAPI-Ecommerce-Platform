using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.DeleteCart;

public record DeleteCartCommand(int Id) : IRequest<Unit>;
