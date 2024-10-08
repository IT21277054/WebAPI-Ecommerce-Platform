// ====================================================
// File: CreateOrderDto.cs
// Description: Data Transfer Object (DTO) for creating a new order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

// DTO for creating a new order
public class CreateOrderDto
{
    public Guid CustomerId { get; set; }
    public string Status { get; set; } = string.Empty;
    public ItemsDto[]? Items { get; set; }
    public double Amount { get; set; }
    public bool? IsCancellationApproved { get; set; }
}

public class ItemsDto
{
    public Guid? VendorId { get; set; }
    public string Status { get; set; } = string.Empty;
    public double Amount { get; set; }
    public int Quantity { get; set; }
}

