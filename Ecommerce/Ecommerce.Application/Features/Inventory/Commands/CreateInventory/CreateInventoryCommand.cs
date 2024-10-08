// ====================================================
// File: CreateInventoryCommand.cs
// Description: Command to create a new inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory;

// Command to create a new inventory item
public record CreateInventoryCommand(CreateInventoryDto dto) : IRequest<Guid>;
