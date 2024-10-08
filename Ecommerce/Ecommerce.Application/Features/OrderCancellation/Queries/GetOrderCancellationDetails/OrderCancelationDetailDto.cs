// ====================================================
// File: OrderCancelationDetailDto.cs
// Description: Data Transfer Object (DTO) representing the details of an order cancellation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;

public class OrderCancelationDetailDto
{
    public Guid Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public Guid OrderId { get; set; }
    public bool? isApproved { get; set; }
}
