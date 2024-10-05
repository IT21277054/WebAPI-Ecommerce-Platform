namespace Ecommerce.Application.Features.Product.Queries.GetProductDetails;

public class ProductDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public bool IsActivated { get; set; }
    public int VendoId { get; set; }

}
