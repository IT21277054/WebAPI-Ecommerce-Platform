using Ecommerce.Application.Features.Order.Commands.CreateOrder;
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

    [HttpGet(Name = "GetAllOrder")]
    [ProducesResponseType(typeof(List<OrderDto>), 200)]
    public async Task<List<OrderDto>> GetAllOrder()
    {
        return await _sender.Send(new GetOrderQuery());
    }

    [HttpGet("{id}", Name = "api/GetByOrderId")]
    [ProducesResponseType(typeof(OrderDetailDto), 200)]
    public async Task<OrderDetailDto> GetByOrderId(int id)
    {
        return await _sender.Send(new GetOrderDetailQuery(id));
    }

    [HttpPost(Name = "CreateOrder")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateOrder(OrderDto OrderDto)
    {
        var result = await _sender.Send(new CreateOrderCommand(OrderDto));

        return Ok(result);
    }

    [HttpPut(Name = "UpdateOrder")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateOrder(OrderDto OrderDto)
    {
        var result = await _sender.Send(new UpdateOrderCommand(OrderDto));

        return Ok(result);

    }

    [HttpDelete("{id}", Name = "DeleteOrder")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteOrder(int id)
    {
        return await _sender.Send(new DeleteUserCommand(id));
    }
}
