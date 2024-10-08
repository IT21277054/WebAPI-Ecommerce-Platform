using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Order.Commands.UpdateItemStatus;

public record UpdateItemStatusCommand(Guid id) : IRequest<ItemsDto>;