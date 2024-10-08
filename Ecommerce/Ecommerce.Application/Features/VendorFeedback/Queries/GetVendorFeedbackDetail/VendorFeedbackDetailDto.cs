// ====================================================
// File: VendorFeedbackDetailDto.cs
// Description: Data Transfer Object (DTO) for vendor feedback details. Represents the specific details of a vendor feedback.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;

public class VendorFeedbackDetailDto
{
    public string Email { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int Rating { get; set; }
}