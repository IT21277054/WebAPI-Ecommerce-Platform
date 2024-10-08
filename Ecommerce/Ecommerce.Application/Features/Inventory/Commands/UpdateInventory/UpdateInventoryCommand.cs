// ====================================================
// File: UpdateInventoryCommand.cs
// Description: Command to update an existing inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.UpdateInventory
{
    public record UpdateInventoryCommand(InventoryDto dto) : IRequest<Guid>; // Command containing inventory DTO for updating
}
