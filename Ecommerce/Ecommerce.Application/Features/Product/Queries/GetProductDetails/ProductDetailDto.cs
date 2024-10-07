namespace Ecommerce.Application.Features.Product.Queries.GetProductDetails;

public class ProductDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Feedback { get; set; } = string.Empty;
    public string VendoId { get; set; }
    public bool IsActivated { get; set; }

}
