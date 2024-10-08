using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.CancelItem;


public record CancelItemCommand(Guid id) : IRequest<ItemsDto>;