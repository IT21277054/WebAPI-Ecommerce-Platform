// ====================================================
// File: UpdateProductCommand.cs
// Description: Command for updating a product with the provided data transfer object (DTO).
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using MediatR;

namespace Ecommerce.Application.Features.Product.Commands.UpdateProduct;

// Command to update a product using the provided ProductDto
public record UpdateProductCommand(ProductDto dto) : IRequest<Guid>;
