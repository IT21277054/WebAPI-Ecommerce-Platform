using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Order.Queries.GetAllOrders;

public class OrderDto
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public string Status { get; set; } = string.Empty;
    public ICollection<Items> Items { get; set; }
    public double Amount { get; set; }
}
