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

    [HttpGet]
    [Route("GetAllInventories")]
    [ProducesResponseType(typeof(List<InventoryDto>), 200)]
    public async Task<List<InventoryDto>> GetAllInventories()
    {
        return await _sender.Send(new GetInventoryQuery());
    }

    [HttpGet]
    [Route("GetByInventorId/{id:Guid}")]
    [ProducesResponseType(typeof(InventoryDetailDto), 200)]
    public async Task<InventoryDetailDto> GetByInventorId(Guid id)
    {
        return await _sender.Send(new GetInventoryDetailQuery(id));
    }

    [HttpPost]
    [Route("CreateInventory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateInventory(CreateInventoryDto inventoryDto)
    {
        var result = await _sender.Send(new CreateInventoryCommand(inventoryDto));

        return Ok(result);
    }


    [HttpPut]
    [Route("UpdateInventory")]
    [HttpPut(Name = "UpdateInventory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateInventory(InventoryDto inventoryDto)
    {
        var result = await _sender.Send(new UpdateInventoryCommand(inventoryDto));

        return Ok(result);

    }

    [HttpDelete]
    [Route("DeleteInventory/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteInventory(Guid id)
    {
        return await _sender.Send(new DeleteInventoryCommand(id));
    }
}