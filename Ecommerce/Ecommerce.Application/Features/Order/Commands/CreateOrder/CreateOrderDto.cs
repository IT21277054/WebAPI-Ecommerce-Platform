﻿// ====================================================
// File: CreateOrderDto.cs
// Description: Data Transfer Object (DTO) for creating a new order.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

// DTO for creating a new order
public class CreateOrderDto
{
    public string CustomerEmail { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public ItemsDto[]? Items { get; set; }
    public double Amount { get; set; }
    public string? cancellationNotice { get; set; } = string.Empty;
}

public class ItemsDto
{
    public Guid? ProductId { get; set; }
    public Guid? VendorId { get; set; }
    public string Status { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Quantity { get; set; }
}

