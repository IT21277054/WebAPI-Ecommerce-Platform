// ====================================================
// File: DeleteInventoryCommand.cs
// Description: Command for deleting an inventory item by its ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

// Command to delete an inventory item by its ID
public record DeleteInventoryCommand(Guid Id) : IRequest<Unit>;
