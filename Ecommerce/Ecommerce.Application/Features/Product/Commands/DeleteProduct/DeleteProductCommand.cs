using MediatR;

namespace Ecommerce.Application.Features.Product.Commands.DeleteProduct;

public record DeleteProductCommand(Guid Id) : IRequest<Unit>;
