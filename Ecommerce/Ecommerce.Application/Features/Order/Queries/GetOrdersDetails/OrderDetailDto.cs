namespace Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;

public class OrderDetailDto
{
    public int Id { get; set; }
    public int Status { get; set; }
    public int[]? Items { get; set; }
    public int Amount { get; set; }
}
