namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public class CreateVendorDto
{
    public string email { get; set; } = string.Empty;
    public string productId { get; set; } = string.Empty;
    public string comment { get; set; } = string.Empty;
    public int rating { get; set; }
}
