// ====================================================
// File: OrderCancellationController.cs
// Description: API controller for managing order cancellation operations 
//              such as getting, creating, updating, and deleting order cancellations.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

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

    // Constructor - Initializes the logger and sender
    public OrderCancellationController(ILogger<OrderCancellationController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/OrderCancellation/GetAllOrderCancellations
    // Retrieves all order cancellations.
    [HttpGet]
    [Route("GetAllOrderCancellations")]
    [ProducesResponseType(typeof(List<OrderCancelationDto>), 200)]
    public async Task<IActionResult> GetAllOrderCancellations()
    {
        var result = await _sender.Send(new GetOrderCancelationQuery());
        return Ok(new { data = result });
    }

    // GET: api/OrderCancellation/GetByOrderCancellationId/{id}
    // Retrieves order cancellation details by ID.
    [HttpGet]
    [Route("GetByOrderCancellationId/{id:Guid}")]
    [ProducesResponseType(typeof(OrderCancelationDetailDto), 200)]
    public async Task<IActionResult> GetByOrderCancellationId(Guid id)
    {
        var result = await _sender.Send(new GetOrderCancelationDetailsQuery(id));
        return Ok(new { data = result });
    }

    // POST: api/OrderCancellation/CreateOrderCancellation
    // Creates a new order cancellation.
    [HttpPost]
    [Route("CreateOrderCancellation")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateOrderCancellation(CreateOrderCancellationDto orderCancellationDto)
    {
        var result = await _sender.Send(new CreateOrderCancellationCommand(orderCancellationDto));
        return Ok(new { id = result });
    }

    // PUT: api/OrderCancellation/UpdateOrderCancellation
    // Updates an existing order cancellation.
    [HttpPut]
    [Route("UpdateOrderCancellation")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateOrderCancellation(OrderCancelationDto orderCancellationDto)
    {
        var result = await _sender.Send(new UpdateOrderCancellationCommand(orderCancellationDto));
        return Ok(new { id = result });
    }

    // DELETE: api/OrderCancellation/DeleteOrderCancellation/{id}
    // Deletes an order cancellation by ID.
    [HttpDelete]
    [Route("DeleteOrderCancellation/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<IActionResult> DeleteOrderCancellation(Guid id)
    {
        var result = await _sender.Send(new DeleteOrderCancellationCommand(id));
        return Ok(new { message = "Order Cancellation deleted successfully." });
    }
}
