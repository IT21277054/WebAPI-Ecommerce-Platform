namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;

public class VendorFeedbackDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid ProductId { get; set; }
    public Guid Rate { get; set; }
    public Guid VendorId { get; set; }
}
