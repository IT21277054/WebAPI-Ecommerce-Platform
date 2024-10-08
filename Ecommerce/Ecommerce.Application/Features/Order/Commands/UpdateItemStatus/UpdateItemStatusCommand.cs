using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.UpdateItemStatus;

public record UpdateItemStatusCommand(Guid id) : IRequest<ItemsDto>;