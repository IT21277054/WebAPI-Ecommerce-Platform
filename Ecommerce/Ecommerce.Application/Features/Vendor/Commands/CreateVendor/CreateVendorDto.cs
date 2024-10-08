// ====================================================
// File: CreateVendorDto.cs
// Description: Represents the data transfer object (DTO) for creating a new vendor.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public class CreateVendorDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
}