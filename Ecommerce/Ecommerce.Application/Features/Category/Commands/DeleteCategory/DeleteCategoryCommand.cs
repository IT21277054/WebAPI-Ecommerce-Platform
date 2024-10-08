// ====================================================
// File: DeleteCategoryCommand.cs
// Description: Command for deleting a category by its ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

// Command to delete a category
public record DeleteCategoryCommand(int Id) : IRequest<Unit>;
