namespace Ecommerce.Application.Features.Product.Commands.CreateProduct;

public class CreateProductDto
{
    public string name { get; set; } = string.Empty;
    public string price { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public string category { get; set; } = string.Empty;
    public string imageUrl { get; set; } = string.Empty;
    public string feedback { get; set; } = string.Empty;
    public string vendorId { get; set; } = string.Empty;
    public bool isActivated { get; set; }

}
