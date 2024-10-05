using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using Ecommerce.Application.Features.Order.Commands.UpdateOrder;
using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using Ecommerce.Application.Features.User.Commands.DeleteUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/Order")]
public class OrderController : ControllerBase
{

    private readonly ILogger<OrderController> _logger;
    private readonly ISender _sender;

    public OrderController(ILogger<OrderController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllOrder")]
    public async Task<List<OrderDto>> GetAllOrder()
    {
        return await _sender.Send(new GetOrderQuery());
    }

    [HttpPost(Name = "CreateOrder")]
    public async Task<IActionResult> CreateOrder(OrderDto OrderDto)
    {
        var result = await _sender.Send(new CreateOrderCommand(OrderDto));

        return Ok(result);
    }

    [HttpPut(Name = "UpdateOrder")]
    public async Task<IActionResult> UpdateOrder(OrderDto OrderDto)
    {
        var result = await _sender.Send(new UpdateOrderCommand(OrderDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteOrder")]
    public async Task<Unit> DeleteOrder()
    {
        return await _sender.Send(new DeleteUserCommand());
    }
}
