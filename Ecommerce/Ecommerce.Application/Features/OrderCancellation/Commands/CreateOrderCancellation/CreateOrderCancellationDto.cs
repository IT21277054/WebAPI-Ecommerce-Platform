// ====================================================
// File: CreateOrderCancellationDto.cs
// Description: Data Transfer Object (DTO) for creating an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

// DTO for representing the data needed to create an order cancellation
public class CreateOrderCancellationDto
{
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public Guid OrderId { get; set; }
    public bool? isApproved { get; set; }
}
