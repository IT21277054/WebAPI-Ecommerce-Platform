using Ecommerce.Application.Features.Inventory.Commands.CreateInventory;
using Ecommerce.Application.Features.Inventory.Commands.DeleteInventory;
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

    public InventoryController(ILogger<InventoryController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllInventories")]
    [ProducesResponseType(typeof(List<InventoryDto>), 200)]
    public async Task<List<InventoryDto>> GetAllInventories()
    {
        return await _sender.Send(new GetInventoryQuery());
    }

    [HttpGet("{id}", Name = "api/GetByInventorId")]
    [ProducesResponseType(typeof(InventoryDetailDto), 200)]
    public async Task<InventoryDetailDto> GetByInventorId(int id)
    {
        return await _sender.Send(new GetInventoryDetailQuery(id));
    }


    [HttpPost(Name = "CreateInventory")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateInventory(InventoryDto inventoryDto)
    {
        var result = await _sender.Send(new CreateInventoryCommand(inventoryDto));

        return Ok(result);
    }


    [HttpPut(Name = "UpdateInventory")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateInventory(InventoryDto inventoryDto)
    {
        var result = await _sender.Send(new UpdateInventoryCommand(inventoryDto));

        return Ok(result);

    }

    [HttpDelete("{id}", Name = "DeleteInventory")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteInventory(int id)
    {
        return await _sender.Send(new DeleteInventoryCommand(id));
    }
}