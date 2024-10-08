// ====================================================
// File: OrderCancelation.cs
// Description: Entity representing the cancellation details of an order.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class OrderCancelation : BaseEntity<Guid>
{
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public Guid OrderId { get; set; }
    public bool? isApproved { get; set; }
}
