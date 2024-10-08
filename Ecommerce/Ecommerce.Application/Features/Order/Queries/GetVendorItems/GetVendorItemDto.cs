namespace Ecommerce.Application.Features.Order.Queries.GetVendorItems;

public class GetVendorItemDto
{
    public Guid Id { get; set; }
    public Guid? VendorId { get; set; }
    public string Status { get; set; } = string.Empty;
    public double Amount { get; set; }
    public int Quantity { get; set; }
}
