// ====================================================
// File: VendorFeedbackDto.cs
// Description: Data Transfer Object (DTO) for vendor feedback. Represents the data that will be transferred between layers.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;

public class VendorFeedbackDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public int Rating { get; set; }
    public Guid VendorId { get; set; }
}