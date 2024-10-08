// ====================================================
// File: ProductsController.cs
// Description: API controller for managing product operations 
//              such as retrieving, creating, updating, and deleting products.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using Ecommerce.Application.Features.Product.Commands.DeleteProduct;
using Ecommerce.Application.Features.Product.Commands.UpdateProduct;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Application.Features.Product.Queries.GetByVendorId;
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

    // Constructor - Initializes the logger and sender
    public ProductsController(ILogger<ProductsController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/Product/GetAllProducts
    // Retrieves all products.
    [HttpGet]
    [Route("GetAllProducts")]
    [ProducesResponseType(typeof(List<ProductDto>), 200)]
    public async Task<IActionResult> GetAllProducts()
    {
        var result = await _sender.Send(new GetProductQuery());
        return Ok(new { data = result });
    }


    // GET: api/Product/GetByProductId/{id}
    // Retrieves product details by product ID.
    [HttpGet]
    [Route("GetByProductId/{id:Guid}")]
    [ProducesResponseType(typeof(ProductDetailDto), 200)]
    public async Task<ProductDetailDto> GetByProductId(Guid id)
    {
        return await _sender.Send(new GetProductDetailQuery(id));
    }

    // GET: api/Product/GetByVendorId/{id}
    // Retrieves products by vendor ID.
    [HttpGet]
    [Route("GetByVendorId/{id:Guid}")]
    [ProducesResponseType(typeof(List<ProductDetailDto>), 200)]
    public async Task<List<ProductDetailDto>> GetByVendorId(Guid id)
    {
        return await _sender.Send(new GetByVendorIdQuery(id));
    }

    // POST: api/Product/CreateProducts
    // Creates a new product.
    [HttpPost]
    [Route("CreateProducts")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateProducts(CreateProductDto productsDto)
    {
        var result = await _sender.Send(new CreateProductCommand(productsDto));
        return Ok(new { id = result });
    }

    // PUT: api/Product/UpdateProducts
    // Updates an existing product.
    [HttpPut]
    [Route("UpdateProducts")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateProducts(ProductDto productsDto)
    {
        var result = await _sender.Send(new UpdateProductCommand(productsDto));
        return Ok(new { id = result });
    }

    // DELETE: api/Product/DeleteProducts/{id}
    // Deletes a product by product ID.
    [HttpDelete]
    [Route("DeleteProducts/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteProducts(Guid id)
    {
        return await _sender.Send(new DeleteProductCommand(id));
    }
}
