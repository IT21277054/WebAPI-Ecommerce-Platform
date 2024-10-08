using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Order.Commands.CreateOrder;

public class CreateOrderDto
{
    public Guid CustomerId { get; set; }
    public string Status { get; set; } = string.Empty;
    public Items[]? Items { get; set; }
    public double Amount { get; set; }
}
