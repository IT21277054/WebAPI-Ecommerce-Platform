﻿using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.DeleteInventory;

public record DeleteInventoryCommand(int Id) : IRequest<Unit>;