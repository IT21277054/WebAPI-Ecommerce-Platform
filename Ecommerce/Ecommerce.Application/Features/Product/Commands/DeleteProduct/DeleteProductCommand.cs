using MediatR;

namespace Ecommerce.Application.Features.Product.Commands.DeleteProduct;

public record DeleteProductCommand(int Id) : IRequest<Unit>;
