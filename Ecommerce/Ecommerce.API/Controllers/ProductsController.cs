using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using Ecommerce.Application.Features.Product.Commands.DeleteProduct;
using Ecommerce.Application.Features.Product.Commands.UpdateProduct;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
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
    [ProducesResponseType(typeof(List<ProductDto>), 200)]
    public async Task<List<ProductDto>> GetAllProducts()
    {
        return await _sender.Send(new GetProductQuery());
    }

    [HttpGet("{id}", Name = "api/GetByProductId")]
    [ProducesResponseType(typeof(ProductDetailDto), 200)]
    public async Task<ProductDetailDto> GetByProductId(int id)
    {
        return await _sender.Send(new GetProductDetailQuery(id));
    }

    [HttpPost(Name = "CreateProducts")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateProducts(CreateProductDto productsDto)
    {
        var result = await _sender.Send(new CreateProductCommand(productsDto));

        return Ok(result);
    }

    [HttpPut(Name = "UpdateProducts")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateProducts(ProductDto ProductsDto)
    {
        var result = await _sender.Send(new UpdateProductCommand(ProductsDto));

        return Ok(result);

    }

    [HttpDelete("{id}", Name = "DeleteProducts")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteProducts(int id)
    {
        return await _sender.Send(new DeleteProductCommand(id));
    }
}
