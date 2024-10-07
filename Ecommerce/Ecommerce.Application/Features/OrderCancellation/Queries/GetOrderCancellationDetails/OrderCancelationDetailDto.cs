namespace Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;

public class OrderCancelationDetailDto
{
    public Guid Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public Guid OrderId { get; set; }
}
