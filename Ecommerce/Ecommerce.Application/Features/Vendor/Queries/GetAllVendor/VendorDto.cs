namespace Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;

public class VendorDto
{
    public Guid Id { get; set; }
    public string email { get; set; } = string.Empty;
    public string productId { get; set; } = string.Empty;
    public string comment { get; set; } = string.Empty;
    public int rating { get; set; }
}
