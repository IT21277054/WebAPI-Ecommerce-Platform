// ====================================================
// File: VendorFeedbackController.cs
// Description: API controller for managing vendor feedback operations 
//              such as retrieving, creating, updating, and deleting vendor feedback.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Commands.UpdateAddVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/vendorFeedback")]
public class VendorFeedbackController : ControllerBase
{
    private readonly ILogger<VendorFeedbackController> _logger;
    private readonly ISender _sender;

    // Constructor - Initializes the logger and sender
    public VendorFeedbackController(ILogger<VendorFeedbackController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/vendorFeedback/GetAllVendorFeedback
    // Retrieves all vendor feedback.
    [HttpGet]
    [Route("GetAllVendorFeedback")]
    [ProducesResponseType(typeof(List<VendorFeedbackDto>), 200)]
    public async Task<IActionResult> GetAllVendorFeedback()
    {
        var result = await _sender.Send(new GetVendorFeedbackQuery());
        return Ok(new { data = result });
    }

    // GET: api/vendorFeedback/GetByVendorFeedbackId/{id}
    // Retrieves vendor feedback details by feedback ID.
    [HttpGet]
    [Route("GetByVendorFeedbackId/{id:Guid}")]
    [ProducesResponseType(typeof(VendorFeedbackDetailDto), 200)]
    public async Task<IActionResult> GetByVendorFeedbackId(Guid id)
    {
        var result = await _sender.Send(new GetVendorFeedbackDetailQuery(id));
        return Ok(new { data = result });
    }

    // POST: api/vendorFeedback/CreateVendorFeedback
    // Creates a new vendor feedback entry.
    [HttpPost]
    [Route("CreateVendorFeedback")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateVendorFeedback(CreateVendorFeedbackDto vendorFeedbackDto)
    {
        var result = await _sender.Send(new CreateVendorFeedbackCommand(vendorFeedbackDto));
        return Ok(new { id = result });
    }

    // PUT: api/vendorFeedback/UpdateVendorFeedback
    // Updates an existing vendor feedback entry.
    [HttpPut]
    [Route("UpdateVendorFeedback")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateVendorFeedback(VendorFeedbackDto vendorFeedbackDto)
    {
        var result = await _sender.Send(new UpdateVendorFeedbackCommand(vendorFeedbackDto));
        return Ok(new { id = result });
    }

    // DELETE: api/vendorFeedback/DeleteVendorFeedback/{id}
    // Deletes vendor feedback by feedback ID.
    [HttpDelete]
    [Route("DeleteVendorFeedback/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<IActionResult> DeleteVendorFeedback(Guid id)
    {
        await _sender.Send(new DeleteVendorFeedbackCommand(id));
        return Ok(new { message = "Vendor Feedback deleted successfully." });
    }
}
