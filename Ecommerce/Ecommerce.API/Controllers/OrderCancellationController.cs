using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Commands.UpdateOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;
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
    [ProducesResponseType(typeof(List<OrderCancelationDto>), 200)]
    public async Task<List<OrderCancelationDto>> GetAllOrderCancellation()
    {
        return await _sender.Send(new GetOrderCancelationQuery());
    }

    [HttpGet("{id}", Name = "api/GetByOrderCancellationId")]
    [ProducesResponseType(typeof(OrderCancelationDetailDto), 200)]
    public async Task<OrderCancelationDetailDto> GetByOrderCancellationId(int id)
    {
        return await _sender.Send(new GetOrderCancelationDetailsQuery(id));
    }

    [HttpPost(Name = "CreateOrderCancellation")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateOrderCancellation(OrderCancelationDto orderCancellationDto)
    {
        var result = await _sender.Send(new CreateOrderCancellationCommand(orderCancellationDto));

        return Ok(result);
    }

    [HttpPut("{id}", Name = "UpdateOrderCancellation")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateOrderCancellation(OrderCancelationDto orderCancellationDto)
    {
        var result = await _sender.Send(new UpdateOrderCancellationCommand(orderCancellationDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteOrderCancellation")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteOrderCancellation(int id)
    {
        return await _sender.Send(new DeleteOrderCancellationCommand(id));
    }
}
