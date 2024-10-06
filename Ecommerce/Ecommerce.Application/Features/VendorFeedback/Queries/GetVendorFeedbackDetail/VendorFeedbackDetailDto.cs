namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;

public class VendorFeedbackDetailDto
{
    public string Email { get; set; } = string.Empty;
    public int ProductId { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int Rating { get; set; }
}
