using Ecommerce.Application.Features.Vendor.Commands.CreateVendor;
using Ecommerce.Application.Features.Vendor.Commands.UpdateVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;


[ApiController]
[Route("api/vendor")]
public class VendorController : ControllerBase
{

    private readonly ILogger<VendorController> _logger;
    private readonly ISender _sender;

    public VendorController(ILogger<VendorController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllVendor")]
    public async Task<List<VendorDto>> GetAllVendor()
    {
        return await _sender.Send(new GetVendorQuery());
    }

    [HttpPost(Name = "CreateVendor")]
    public async Task<IActionResult> CreateVendor(VendorDto vendorDto)
    {
        var result = await _sender.Send(new CreateVendorCommand(vendorDto));

        return Ok(new { Response = result });
    }

    [HttpPut(Name = "UpdateVendor")]
    public async Task<IActionResult> UpdateVendor(VendorDto vendorDto)
    {
        var result = await _sender.Send(new UpdateVendorCommand(vendorDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteVendor")]
    public async Task<List<VendorDto>> DeleteVendor()
    {
        return await _sender.Send(new GetVendorQuery());
    }
}
