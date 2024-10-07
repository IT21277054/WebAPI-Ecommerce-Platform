namespace Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;

public class VendorDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
}
