// ====================================================
// File: CreateOrderDto.cs
// Description: Data Transfer Object (DTO) for creating a new order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain; // Domain model for items

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

// DTO for creating a new order
public class CreateOrderDto
{
    public Guid CustomerId { get; set; }
    public string Status { get; set; } = string.Empty;
    public Items[]? Items { get; set; }
    public double Amount { get; set; }
}
