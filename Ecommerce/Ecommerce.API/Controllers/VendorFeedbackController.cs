using Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;
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
    public async Task<List<VendorFeedbackDto>> GetAllVendorFeedback()
    {
        return await _sender.Send(new GetVendorFeedbackQuery());
    }

    [HttpPost(Name = "CreateVendorFeedback")]
    public async Task<IActionResult> CreateVendorFeedback(VendorFeedbackDto vendorFeedbackDto)
    {
        var result = await _sender.Send(new CreateVendorFeedbackCommand(vendorFeedbackDto));

        return Ok(new { Response = result });
    }

    [HttpPut(Name = "UpdateVendorFeedback")]
    public async Task<IActionResult> UpdateVendorFeedback(VendorFeedbackDto vendorFeedbackDto)
    {
        var result = await _sender.Send(new UpdateVendorFeedbackCommand(vendorFeedbackDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteVendorFeedback")]
    public async Task<List<VendorFeedbackDto>> DeleteVendorFeedback()
    {
        return await _sender.Send(new GetVendorFeedbackQuery());
    }
}
