namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public class CreateVendorDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
}
