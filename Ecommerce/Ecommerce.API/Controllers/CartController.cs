using Ecommerce.Application.Features.Cart.Commands.CreateCart;
using Ecommerce.Application.Features.Cart.Commands.DeleteCart;
using Ecommerce.Application.Features.Cart.Commands.UpdateCart;
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

    public CartController(ILogger<CartController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet]
    [Route("GetAllCart")]
    [ProducesResponseType(typeof(List<CartDto>), 200)]
    public async Task<List<CartDto>> GetAllCart()
    {
        return await _sender.Send(new GetCartAllQuery());
    }

    [HttpGet]
    [Route("GetByCartId/{id:Guid}")]
    [ProducesResponseType(typeof(CartDetailDto), 200)]
    public async Task<CartDetailDto> GetByCartId(Guid id)
    {
        return await _sender.Send(new GetCartDetailsQuery(id));
    }


    [HttpPost]
    [Route("CreateCart")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateCart(CreateCartDto CartDto)
    {
        var result = await _sender.Send(new CreateCartCommand(CartDto));

        return Ok(result);
    }

    [HttpPut]
    [Route("UpdateCart")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateCart(CartDto cartDto)
    {
        var result = await _sender.Send(new UpdateCartCommand(cartDto));

        return Ok(result);

    }

    [HttpDelete]
    [Route("DeleteCart/{id:Guid}")]
    public async Task<Unit> DeleteCart(Guid id)
    {
        return await _sender.Send(new DeleteCartCommand(id));
    }
}

