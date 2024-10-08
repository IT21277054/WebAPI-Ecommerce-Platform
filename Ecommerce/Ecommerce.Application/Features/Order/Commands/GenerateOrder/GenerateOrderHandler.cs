using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.GenerateOrder;

public record GenerateOrderHandler(string email) : IRequest<Guid>;