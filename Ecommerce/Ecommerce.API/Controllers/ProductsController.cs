using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.Product.Commands.DeleteProduct;
using Ecommerce.Application.Features.Product.Commands.UpdateProduct;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;


[ApiController]
[Route("api/Product")]
public class ProductsController : ControllerBase
{

    private readonly ILogger<ProductsController> _logger;
    private readonly ISender _sender;

    public ProductsController(ILogger<ProductsController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllProducts")]
    public async Task<List<ProductDto>> GetAllProducts()
    {
        return await _sender.Send(new GetProductQuery());
    }

    [HttpPost(Name = "CreateProducts")]
    public async Task<IActionResult> CreateProducts(ProductDto ProductsDto)
    {
        var result = await _sender.Send(new CreateProductCommand(ProductsDto));

        return Ok(result);
    }

    [HttpPut(Name = "UpdateProducts")]
    public async Task<IActionResult> UpdateProducts(ProductDto ProductsDto)
    {
        var result = await _sender.Send(new UpdateProductCommand(ProductsDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteProducts")]
    public async Task<Unit> DeleteProducts()
    {
        return await _sender.Send(new DeleteProductCommand());
    }
}
