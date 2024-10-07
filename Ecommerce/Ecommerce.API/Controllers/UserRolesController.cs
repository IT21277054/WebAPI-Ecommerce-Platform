using Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;
using Ecommerce.Application.Features.UserRoles.Commands.DeleteUserRole;
using Ecommerce.Application.Features.UserRoles.Commands.UpdateUserRole;
using Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;
using Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;
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

    [HttpGet]
    [Route("GetAllUserRoles")]
    [ProducesResponseType(typeof(List<UserRoleDto>), 200)]
    public async Task<List<UserRoleDto>> GetAllUserRoles()
    {
        return await _sender.Send(new GetUserRolesQuery());
    }

    [HttpGet]
    [Route("GetByUserRolesId/{id:int}")]
    [ProducesResponseType(typeof(UserRoleDetailDto), 200)]
    public async Task<UserRoleDetailDto> GetByUserRolesId(int id)
    {
        return await _sender.Send(new GetUserRoleDetailQuery(id));
    }

    [HttpPost]
    [Route("CreateUserRoles")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateUserRoles(UserRoleDto userRolesDto)
    {
        var result = await _sender.Send(new CreateUserRoleCommand(userRolesDto));

        return Ok(result);
    }

    [HttpPut]
    [Route("UpdateUserRoles")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateUserRoles(UserRoleDto userRolesDto)
    {
        var result = await _sender.Send(new UpdateUserRoleCommand(userRolesDto));

        return Ok(result);
    }

    [HttpDelete]
    [Route("DeleteUserRoles/{id:int}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteUserRoles(int id)
    {
        return await _sender.Send(new DeleteUserRoleCommand(id));
    }
}
