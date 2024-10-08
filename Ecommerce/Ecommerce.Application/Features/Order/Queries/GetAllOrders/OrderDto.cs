// ====================================================
// File: OrderDto.cs
// Description: Data Transfer Object (DTO) representing an order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain; // Domain model for items

namespace Ecommerce.Application.Features.Order.Queries.GetAllOrders;

// DTO for representing an order
public class OrderDto
{
    public Guid Id { get; set; }
    public string CustomerEmail { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public ICollection<Items> Items { get; set; }
    public double Amount { get; set; }
    public string? cancellationNotice { get; set; } = string.Empty;
}
