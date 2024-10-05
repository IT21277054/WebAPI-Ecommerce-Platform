namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;

public class VendorFeedbackDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Rate { get; set; }
    public int VendorId { get; set; }
}
