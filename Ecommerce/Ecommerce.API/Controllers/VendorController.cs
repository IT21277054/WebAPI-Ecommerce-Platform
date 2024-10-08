// ====================================================
// File: VendorController.cs
// Description: API controller for managing vendor operations 
//              such as retrieving, creating, updating, and deleting vendors.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Vendor.Commands.CreateVendor;
using Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;
using Ecommerce.Application.Features.Vendor.Commands.UpdateVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetVendorDetailQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/vendor")]
public class VendorController : ControllerBase
{
    private readonly ILogger<VendorController> _logger;
    private readonly ISender _sender;

    // Constructor - Initializes the logger and sender
    public VendorController(ILogger<VendorController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/vendor/GetAllVendor
    // Retrieves all vendors.
    [HttpGet]
    [Route("GetAllVendor")]
    [ProducesResponseType(typeof(List<VendorDto>), 200)]
    public async Task<List<VendorDto>> GetAllVendor()
    {
        return await _sender.Send(new GetVendorQuery());
    }

    // GET: api/vendor/GetByVendorId/{id}
    // Retrieves vendor details by vendor ID.
    [HttpGet]
    [Route("GetByVendorId/{id:Guid}")]
    [ProducesResponseType(typeof(VendorDetailDto), 200)]
    public async Task<VendorDetailDto> GetByVendorId(Guid id)
    {
        return await _sender.Send(new GetVendorDetailQuery(id));
    }

    // POST: api/vendor/CreateVendor
    // Creates a new vendor.
    [HttpPost]
    [Route("CreateVendor")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateVendor(CreateVendorDto vendorDto)
    {
        var result = await _sender.Send(new CreateVendorCommand(vendorDto));
        return Ok(result);
    }

    // PUT: api/vendor/UpdateVendor
    // Updates an existing vendor.
    [HttpPut]
    [Route("UpdateVendor")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateVendor(VendorDto vendorDto)
    {
        var result = await _sender.Send(new UpdateVendorCommand(vendorDto));
        return Ok(result);
    }

    // DELETE: api/vendor/DeleteVendor/{id}
    // Deletes a vendor by vendor ID.
    [HttpDelete]
    [Route("DeleteVendor/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteVendor(Guid id)
    {
        return await _sender.Send(new DeleteVendorCommand(id));
    }
}
