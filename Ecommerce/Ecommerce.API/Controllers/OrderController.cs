using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using Ecommerce.Application.Features.Order.Commands.DeleteOrder;
using Ecommerce.Application.Features.Order.Commands.UpdateOrder;
using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;
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

    [HttpGet]
    [Route("GetAllOrders")]
    [ProducesResponseType(typeof(List<OrderDto>), 200)]
    public async Task<List<OrderDto>> GetAllOrders()
    {
        return await _sender.Send(new GetOrderQuery());
    }

    [HttpGet]
    [Route("GetByOrderId/{id:int}")]
    [ProducesResponseType(typeof(OrderDetailDto), 200)]
    public async Task<OrderDetailDto> GetByOrderId(int id)
    {
        return await _sender.Send(new GetOrderDetailQuery(id));
    }

    [HttpPost]
    [Route("CreateOrder")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateOrder(OrderDto orderDto)
    {
        var result = await _sender.Send(new CreateOrderCommand(orderDto));

        return Ok(result);
    }

    [HttpPut]
    [Route("UpdateOrder")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateOrder(OrderDto orderDto)
    {
        var result = await _sender.Send(new UpdateOrderCommand(orderDto));

        return Ok(result);
    }

    [HttpDelete]
    [Route("DeleteOrder/{id:int}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteOrder(int id)
    {
        return await _sender.Send(new DeleteOrderCommand(id));
    }
}

