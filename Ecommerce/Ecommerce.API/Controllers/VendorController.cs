using Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;
using Ecommerce.Application.Features.Vendor.Commands.CreateVendor;
using Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;
using Ecommerce.Application.Features.Vendor.Commands.UpdateVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetVendorDetails;
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
    [ProducesResponseType(typeof(List<VendorDto>), 200)]
    public async Task<List<VendorDto>> GetAllVendor()
    {
        return await _sender.Send(new GetVendorQuery());
    }

    [HttpGet("{id}", Name = "api/GetByVendorId")]
    [ProducesResponseType(typeof(VendorDetailDto), 200)]
    public async Task<VendorDetailDto> GetByVendorId(int id)
    {
        return await _sender.Send(new GetVendorDetailQuery(id));
    }

    [HttpPost(Name = "CreateVendor")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateVendor(VendorDto vendorDto)
    {
        var result = await _sender.Send(new CreateVendorCommand(vendorDto));

        return Ok(result);
    }

    [HttpPut("{id}", Name = "UpdateVendor")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateVendor(VendorDto vendorDto)
    {
        var result = await _sender.Send(new UpdateVendorCommand(vendorDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteVendor")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteVendor(int id)
    {
        return await _sender.Send(new DeleteVendorCommand(id));
    }
}
