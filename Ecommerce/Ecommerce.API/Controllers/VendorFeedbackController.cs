using Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Commands.UpdateAddVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/vendorFeedback")]
public class VendorFeedbackController : ControllerBase
{

    private readonly ILogger<VendorFeedbackController> _logger;
    private readonly ISender _sender;

    public VendorFeedbackController(ILogger<VendorFeedbackController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllVendorFeedback")]
    [ProducesResponseType(typeof(List<VendorFeedbackDto>), 200)]
    public async Task<IActionResult> GetAllVendorFeedback()
    {
        var result = await _sender.Send(new GetVendorFeedbackQuery());

        return Ok(result);
    }

    [HttpPost(Name = "CreateVendorFeedback")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateVendorFeedback(VendorFeedbackDto vendorFeedbackDto)
    {
        var result = await _sender.Send(new CreateVendorFeedbackCommand(vendorFeedbackDto));

        return Ok(result);
    }

    [HttpPut(Name = "UpdateVendorFeedback")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateVendorFeedback(VendorFeedbackDto vendorFeedbackDto)
    {
        var result = await _sender.Send(new UpdateVendorFeedbackCommand(vendorFeedbackDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteVendorFeedback")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteVendorFeedback()
    {
        return await _sender.Send(new DeleteVendorFeedbackCommand());
    }
}
