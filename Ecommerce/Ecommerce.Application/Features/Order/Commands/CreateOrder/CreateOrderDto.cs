namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

public class CreateOrderDto
{
    public int Status { get; set; }
    public int[]? Items { get; set; }
    public int Amount { get; set; }
}
