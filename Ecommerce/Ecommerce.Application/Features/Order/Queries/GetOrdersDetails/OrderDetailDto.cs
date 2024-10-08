using Ecommerce.Domain;

namespace Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;

public class OrderDetailDto
{
    public Guid Id { get; set; }
    public string Status { get; set; } = string.Empty;
    public ICollection<Items> Items { get; set; }
    public double Amount { get; set; }
}
