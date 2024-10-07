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

    [HttpGet]
    [Route("GetAllProducts")]
    [ProducesResponseType(typeof(List<ProductDto>), 200)]
    public async Task<List<ProductDto>> GetAllProducts()
    {
        return await _sender.Send(new GetProductQuery());
    }

    [HttpGet]
    [Route("GetByProductId/{id:int}")]
    [ProducesResponseType(typeof(ProductDetailDto), 200)]
    public async Task<ProductDetailDto> GetByProductId(int id)
    {
        return await _sender.Send(new GetProductDetailQuery(id));
    }

    [HttpPost]
    [Route("CreateProducts")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateProducts(CreateProductDto productsDto)
    {
        var result = await _sender.Send(new CreateProductCommand(productsDto));

        return Ok(result);
    }

    [HttpPut]
    [Route("UpdateProducts")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateProducts(ProductDto productsDto)
    {
        var result = await _sender.Send(new UpdateProductCommand(productsDto));

        return Ok(result);
    }

    [HttpDelete]
    [Route("DeleteProducts/{id:int}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteProducts(int id)
    {
        return await _sender.Send(new DeleteProductCommand(id));
    }
}
