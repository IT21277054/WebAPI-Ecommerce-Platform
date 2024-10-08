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
    public async Task<List<CartDto>> GetAllCart()
    {
        return await _sender.Send(new GetCartAllQuery());
    }

    // GET: api/Cart/GetByCartId/{id}
    // Retrieves cart details by ID.
    [HttpGet]
    [Route("GetByCartId/{id:Guid}")]
    [ProducesResponseType(typeof(CartDetailDto), 200)]
    public async Task<CartDetailDto> GetByCartId(Guid id)
    {
        return await _sender.Send(new GetCartDetailsQuery(id));
    }

    // POST: api/Cart/CreateCart
    // Creates a new cart.
    [HttpPost]
    [Route("CreateCart")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateCart(CreateCartDto CartDto)
    {
        var result = await _sender.Send(new CreateCartCommand(CartDto));
        return Ok(result);
    }

    // PUT: api/Cart/UpdateCart
    // Updates an existing cart.
    [HttpPut]
    [Route("UpdateCart")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateCart(CartDto cartDto)
    {
        var result = await _sender.Send(new UpdateCartCommand(cartDto));
        return Ok(result);
    }

    // DELETE: api/Cart/DeleteCart/{id}
    // Deletes a cart by ID.
    [HttpDelete]
    [Route("DeleteCart/{id:Guid}")]
    public async Task<Unit> DeleteCart(Guid id)
    {
        return await _sender.Send(new DeleteCartCommand(id));
    }
}
