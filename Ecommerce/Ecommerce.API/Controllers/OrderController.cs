﻿// ====================================================
// File: OrderController.cs
// Description: API controller for managing order operations 
//              such as getting, creating, updating, and deleting orders.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using Ecommerce.Application.Features.Order.Commands.DeleteOrder;
using Ecommerce.Application.Features.Order.Commands.UpdateOrder;
using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
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
        public async Task<List<OrderDto>> GetAllOrders()
        {
            return await _sender.Send(new GetOrderQuery());
        }

        // GET: api/Order/GetByOrderId/{id}
        // Retrieves order details by ID.
        [HttpGet]
        [Route("GetByOrderId/{id:Guid}")]
        [ProducesResponseType(typeof(OrderDetailDto), 200)]
        public async Task<OrderDetailDto> GetByOrderId(Guid id)
        {
            return await _sender.Send(new GetOrderDetailQuery(id));
        }

        // POST: api/Order/CreateOrder
        // Creates a new order.
        [HttpPost]
        [Route("CreateOrder")]
        [ProducesResponseType(typeof(Guid), 200)]
        public async Task<IActionResult> CreateOrder(CreateOrderDto orderDto)
        {
            var result = await _sender.Send(new CreateOrderCommand(orderDto));
            return Ok(result);
        }

        // PUT: api/Order/UpdateOrder
        // Updates an existing order.
        [HttpPut]
        [Route("UpdateOrder")]
        [ProducesResponseType(typeof(Guid), 200)]
        public async Task<IActionResult> UpdateOrder(OrderDto orderDto)
        {
            var result = await _sender.Send(new UpdateOrderCommand(orderDto));
            return Ok(result);
        }

        // DELETE: api/Order/DeleteOrder/{id}
        // Deletes an order by ID.
        [HttpDelete]
        [Route("DeleteOrder/{id:Guid}")]
        [ProducesResponseType(typeof(Unit), 200)]
        public async Task<Unit> DeleteOrder(Guid id)
        {
            return await _sender.Send(new DeleteOrderCommand(id));
        }
    }
}
