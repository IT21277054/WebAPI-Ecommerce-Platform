// ====================================================
// File: DeleteProductCommand.cs
// Description: Command for deleting a product by its ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.Product.Commands.DeleteProduct;

public record DeleteProductCommand(Guid Id) : IRequest<Unit>;
