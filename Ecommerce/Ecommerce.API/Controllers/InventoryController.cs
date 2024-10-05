using Ecommerce.Application.Features.Inventory.Commands.CreateInventory;
using Ecommerce.Application.Features.Inventory.Commands.DeleteInventory;
using Ecommerce.Application.Features.Inventory.Commands.UpdateInventory;
using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/Inventory")]
public class InventoryController : ControllerBase
{

    private readonly ILogger<InventoryController> _logger;
    private readonly ISender _sender;

    public InventoryController(ILogger<InventoryController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllInventories")]
    public async Task<List<InventoryDto>> GetAllInventories()
    {
        return await _sender.Send(new GetInventoryQuery());
    }

    [HttpPost(Name = "CreateInventory")]
    public async Task<IActionResult> CreateInventory(InventoryDto inventoryDto)
    {
        var result = await _sender.Send(new CreateInventoryCommand(inventoryDto));

        return Ok(result);
    }


    [HttpPut(Name = "UpdateInventory")]
    public async Task<IActionResult> UpdateInventory(InventoryDto inventoryDto)
    {
        var result = await _sender.Send(new UpdateInventoryCommand(inventoryDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteInventory")]
    public async Task<Unit> DeleteInventory()
    {
        return await _sender.Send(new DeleteInventoryCommand());
    }
}