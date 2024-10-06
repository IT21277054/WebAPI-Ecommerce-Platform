namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetails;

public class VendorDetailDto
{
    public int Id { get; set; }
    public string email { get; set; } = string.Empty;
    public string productId { get; set; } = string.Empty;
    public string comment { get; set; } = string.Empty;
    public int rating { get; set; }
}
