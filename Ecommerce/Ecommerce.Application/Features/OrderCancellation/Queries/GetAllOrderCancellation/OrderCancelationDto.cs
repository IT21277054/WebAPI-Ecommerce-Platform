﻿namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;

public class OrderCancelationDto
{
    public int Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public int OrderId { get; set; }
}
