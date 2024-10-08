// ====================================================
// File: DeleteCartCommand.cs
// Description: Command for deleting a cart by its ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

// Command to delete a cart by ID
public record DeleteCartCommand(Guid Id) : IRequest<Unit>;
