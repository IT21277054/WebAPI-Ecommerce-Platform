// ====================================================
// File: OrderController.cs
// Description: API controller for managing order operations 
//              such as getting, creating, updating, and deleting orders.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Order.Commands.CancelItem;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using Ecommerce.Application.Features.Order.Commands.DeleteOrder;
using Ecommerce.Application.Features.Order.Commands.GenerateOrder;
using Ecommerce.Application.Features.Order.Commands.UpdateItemStatus;
using Ecommerce.Application.Features.Order.Commands.UpdateItemWithItemId;
using Ecommerce.Application.Features.Order.Commands.UpdateOrder;
using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using Ecommerce.Application.Features.Order.Queries.GetOrderByEmail;
using Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;
using Ecommerce.Application.Features.Order.Queries.GetVendorItems;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/Order")]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly ISender _sender;

    // Constructor - Initializes the logger and sender
    public OrderController(ILogger<OrderController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/Order/GetAllOrders
    // Retrieves all orders.
    [HttpGet]
    [Route("GetAllOrders")]
    [ProducesResponseType(typeof(List<OrderDto>), 200)]
    public async Task<IActionResult> GetAllOrders()
    {
        var result = await _sender.Send(new GetOrderQuery());
        return Ok(new { data = result });
    }

    // GET: api/Order/GetByOrderId/{id}
    // Retrieves order details by ID.
    [HttpGet]
    [Route("GetByOrderId/{id:Guid}")]
    [ProducesResponseType(typeof(OrderDetailDto), 200)]
    public async Task<IActionResult> GetByOrderId(Guid id)
    {
        var result = await _sender.Send(new GetOrderDetailQuery(id));
        return Ok(new { data = result });
    }

    // GET: api/Order/GetByOrderId/{id}
    // Retrieves order details by ID.
    [HttpGet]
    [Route("GenerateOrder")]
    [ProducesResponseType(typeof(OrderDetailDto), 200)]
    public async Task<IActionResult> GenerateOrder(string email)
    {
        var result = await _sender.Send(new GenerateOrderHandler(email));
        return Ok(new { data = result });
    }

    // GET: api/Order/GetByItemsById/{VendorId}
    // Retrieves items related to a vendor Id.
    [HttpGet]
    [Route("GetByItemsVendorById/{vendorId:Guid}")]
    [ProducesResponseType(typeof(ItemsDto), 200)]
    public async Task<IActionResult> GetByItemsById(Guid vendorId)
    {
        var result = await _sender.Send(new GetVendorItemQuery(vendorId));
        return Ok(new { data = result });
    }

    // GET: api/Order/GetByItemsById/{VendorId}
    // Retrieves items related to a vendor Id.
    [HttpGet]
    [Route("GetOrderByEmail")]
    [ProducesResponseType(typeof(OrderDetailDto), 200)]
    public async Task<IActionResult> GetOrderByEmail(string email)
    {
        var result = await _sender.Send(new GetOrderByEmailQuery(email));
        return Ok(new { data = result });
    }

    // PUT: api/Order/CancelItem/{VendorId}
    // Request to cancel item.
    [HttpPut]
    [Route("CancelItem/{itemId:Guid}")]
    [ProducesResponseType(typeof(ItemsDto), 200)]
    public async Task<IActionResult> CancelItem(Guid itemId)
    {
        var result = await _sender.Send(new CancelItemCommand(itemId));
        return Ok(new { data = result });
    }

    // PUT: api/Order/CancelItem/{VendorId}
    // Request to cancel item.
    [HttpPut]
    [Route("UpdateItemStatusByItemId/{itemId:Guid}")]
    [ProducesResponseType(typeof(ItemsDto), 200)]
    public async Task<IActionResult> UpdateItemStatusByItemId(Guid itemId)
    {
        var result = await _sender.Send(new UpdateItemStatusCommand(itemId));
        return Ok(new { data = result });
    }

    // POST: api/Order/CreateOrder
    // Creates a new order.
    [HttpPost]
    [Route("CreateOrder")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateOrder(CreateOrderDto orderDto)
    {
        var result = await _sender.Send(new CreateOrderCommand(orderDto));
        return Ok(new { id = result });
    }

    // PUT: api/Order/UpdateOrder
    // Updates an existing order.
    [HttpPut]
    [Route("UpdateOrder")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateOrder(OrderDto orderDto)
    {
        var result = await _sender.Send(new UpdateOrderCommand(orderDto));
        return Ok(new { id = result });
    }

    // PUT: api/Order/UpdateItem
    // Updates an existing item.
    [HttpPut]
    [Route("UpdateItem")]
    [ProducesResponseType(typeof(GetVendorItemDto), 200)]
    public async Task<IActionResult> UpdateItem(GetVendorItemDto itemDto)
    {
        var result = await _sender.Send(new UpdateItemCommand(itemDto));
        return Ok(new { id = result });
    }

    // DELETE: api/Order/DeleteOrder/{id}
    // Deletes an order by ID.
    [HttpDelete]
    [Route("DeleteOrder/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<IActionResult> DeleteOrder(Guid id)
    {
        await _sender.Send(new DeleteOrderCommand(id));
        return Ok(new { message = "Product deleted successfully." });
    }
}
