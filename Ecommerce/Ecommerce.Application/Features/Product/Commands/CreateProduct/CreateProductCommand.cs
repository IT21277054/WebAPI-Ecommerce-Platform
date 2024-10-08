// ====================================================
// File: CreateProductCommand.cs
// Description: Command for creating a new product in the order cancellation process.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateProductCommand(CreateProductDto dto) : IRequest<Guid>;
