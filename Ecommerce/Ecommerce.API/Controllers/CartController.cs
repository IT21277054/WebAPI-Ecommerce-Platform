// ====================================================
// File: CartController.cs
// Description: API controller for managing cart operations 
//              such as getting, creating, updating, and deleting carts.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Cart.Commands.CreateCart;
using Ecommerce.Application.Features.Cart.Queries.GetAllCarts;
using Ecommerce.Application.Features.Cart.Queries.GetCartDetails;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/Cart")]
public class CartController : ControllerBase
{
    private readonly ILogger<CartController> _logger;
    private readonly ISender _sender;

    // Constructor - Initializes the logger and sender
    public CartController(ILogger<CartController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/Cart/GetAllCart
    // Retrieves all carts.
    [HttpGet]
    [Route("GetAllCart")]
    [ProducesResponseType(typeof(List<CartDto>), 200)]
    public async Task<IActionResult> GetAllCart()
    {
        var result = await _sender.Send(new GetCartAllQuery());
        return Ok(new { data = result });
    }

    // GET: api/Cart/GetByCartId/{id}
    // Retrieves cart details by ID.
    [HttpGet]
    [Route("GetByCartEmail")]
    [ProducesResponseType(typeof(CartDetailDto), 200)]
    public async Task<IActionResult> GetByCartEmail(string email)
    {
        var result = await _sender.Send(new GetCartDetailsQuery(email));
        return Ok(new { data = result });
    }

    // POST: api/Cart/CreateCart
    // Creates a new cart.
    [HttpPost]
    [Route("CreateCart")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateCart(CreateCartDto CartDto)
    {
        var result = await _sender.Send(new CreateCartCommand(CartDto));
        return Ok(new { id = result });
    }

    // PUT: api/Cart/UpdateCart
    // Updates an existing cart.
    [HttpPut]
    [Route("UpdateCart")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateCart(string email, ProductDto cartDto)
    {
        var result = await _sender.Send(new UpdateCartCommand(email, cartDto));
        return Ok(new { id = result });
    }

    // DELETE: api/Cart/DeleteCart/{id}
    // Deletes a cart by ID.
    [HttpDelete]
    [Route("DeleteCart/{id:Guid}")]
    public async Task<IActionResult> DeleteCart(Guid id)
    {
        await _sender.Send(new DeleteCartCommand(id));
        return Ok(new { message = "Cart deleted successfully." });
    }
}
