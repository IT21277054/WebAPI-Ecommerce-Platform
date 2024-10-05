namespace Ecommerce.Application.Features.Product.Queries.GetAllProducts;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public bool IsActivated { get; set; }
    public int VendoId { get; set; }

}
