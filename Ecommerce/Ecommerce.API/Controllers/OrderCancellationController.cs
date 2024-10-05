using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Commands.UpdateOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/OrderCancellation")]
public class OrderCancellationController : ControllerBase
{

    private readonly ILogger<OrderCancellationController> _logger;
    private readonly ISender _sender;

    public OrderCancellationController(ILogger<OrderCancellationController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllOrderCancellation")]
    public async Task<List<OrderCancelationDto>> GetAllOrderCancellation()
    {
        return await _sender.Send(new GetOrderCancelationQuery());
    }

    [HttpPost(Name = "CreateOrderCancellation")]
    public async Task<IActionResult> CreateOrderCancellation(OrderCancelationDto orderCancellationDto)
    {
        var result = await _sender.Send(new CreateOrderCancellationCommand(orderCancellationDto));

        return Ok(result);
    }

    [HttpPut(Name = "UpdateOrderCancellation")]
    public async Task<IActionResult> UpdateOrderCancellation(OrderCancelationDto orderCancellationDto)
    {
        var result = await _sender.Send(new UpdateOrderCancellationCommand(orderCancellationDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteOrderCancellation")]
    public async Task<Unit> DeleteOrderCancellation()
    {
        return await _sender.Send(new DeleteOrderCancellationCommand());
    }
}
