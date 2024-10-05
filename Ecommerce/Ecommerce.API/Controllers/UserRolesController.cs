using Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;
using Ecommerce.Application.Features.UserRoles.Commands.UpdateUserRole;
using Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/UserRoles")]
public class UserRolesController : ControllerBase
{

    private readonly ILogger<UserRolesController> _logger;
    private readonly ISender _sender;

    public UserRolesController(ILogger<UserRolesController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllUserRoles")]
    public async Task<List<UserRoleDto>> GetAllUserRoles()
    {
        return await _sender.Send(new GetUserRolesQuery());
    }

    [HttpPost(Name = "CreateUserRoles")]
    public async Task<IActionResult> CreateUserRoles(UserRoleDto userRolesDto)
    {
        var result = await _sender.Send(new CreateUserRoleCommand(userRolesDto));

        return Ok(new { Response = result });
    }


    [HttpPut(Name = "UpdateUserRoles")]
    public async Task<IActionResult> UpdateUserRoles(UserRoleDto userRolesDto)
    {
        var result = await _sender.Send(new UpdateUserRoleCommand(userRolesDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteUserRoles")]
    public async Task<List<UserRoleDto>> DeleteUserRoles()
    {
        return await _sender.Send(new GetUserRolesQuery());
    }
}