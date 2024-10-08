// ====================================================
// File: CreateVendorFeedbackDto.cs
// Description: Represents the data transfer object (DTO) for creating a new vendor feedback.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;

public class CreateVendorFeedbackDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public Guid Rate { get; set; }
    public Guid VendorId { get; set; }
}