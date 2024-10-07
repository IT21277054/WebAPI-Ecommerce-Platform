namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetails;

public class VendorDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
}
