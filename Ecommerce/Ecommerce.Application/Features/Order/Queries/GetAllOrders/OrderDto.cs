namespace Ecommerce.Application.Features.Order.Queries.GetAllOrders;

public class OrderDto
{
    public Guid Id { get; set; }
    public int Status { get; set; }
    public int[]? Items { get; set; }
    public int Amount { get; set; }
}
