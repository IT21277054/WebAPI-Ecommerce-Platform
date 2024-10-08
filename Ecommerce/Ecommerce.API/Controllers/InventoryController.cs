// ====================================================
// File: InventoryController.cs
// Description: API controller for managing inventory operations 
//              such as getting, creating, updating, and deleting inventories.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Inventory.Commands.CreateInventory;
using Ecommerce.Application.Features.Inventory.Commands.UpdateInventory;
using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/Inventory")]
public class InventoryController : ControllerBase
{
    private readonly ILogger<InventoryController> _logger;
    private readonly ISender _sender;

    // Constructor - Initializes the logger and sender
    public InventoryController(ILogger<InventoryController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/Inventory/GetAllInventories
    // Retrieves all inventory items.
    [HttpGet]
    [Route("GetAllInventories")]
    [ProducesResponseType(typeof(List<InventoryDto>), 200)]
    public async Task<IActionResult> GetAllInventories()
    {
        var result = await _sender.Send(new GetInventoryQuery());
        return Ok(new { data = result });
    }

    // GET: api/Inventory/GetByInventorId/{id}
    // Retrieves inventory details by ID.
    [HttpGet]
    [Route("GetByInventorId/{id:Guid}")]
    [ProducesResponseType(typeof(InventoryDetailDto), 200)]
    public async Task<IActionResult> GetByInventorId(Guid id)
    {
        var result = await _sender.Send(new GetInventoryDetailQuery(id));
        return Ok(new { data = result });
    }

    // POST: api/Inventory/CreateInventory
    // Creates a new inventory item.
    [HttpPost]
    [Route("CreateInventory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateInventory(CreateInventoryDto inventoryDto)
    {
        var result = await _sender.Send(new CreateInventoryCommand(inventoryDto));
        return Ok(new { id = result });
    }

    // PUT: api/Inventory/UpdateInventory
    // Updates an existing inventory item.
    [HttpPut]
    [Route("UpdateInventory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateInventory(InventoryDto inventoryDto)
    {
        var result = await _sender.Send(new UpdateInventoryCommand(inventoryDto));
        return Ok(new { id = result });
    }

    // DELETE: api/Inventory/DeleteInventory/{id}
    // Deletes an inventory item by ID.
    [HttpDelete]
    [Route("DeleteInventory/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<IActionResult> DeleteInventory(Guid id)
    {
        var result = await _sender.Send(new DeleteInventoryCommand(id));
        return Ok(new { message = "Inventory deleted successfully." });
    }
}
