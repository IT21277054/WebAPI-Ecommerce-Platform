// ====================================================
// File: VendorDetailDto.cs
// Description: Represents the data transfer object (DTO) for vendor details.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetailQuery; // Corrected Namespace

public class VendorDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
}