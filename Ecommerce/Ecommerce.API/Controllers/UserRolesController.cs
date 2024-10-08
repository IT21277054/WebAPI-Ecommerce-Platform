// ====================================================
// File: UserRolesController.cs
// Description: API controller for managing user roles operations 
//              such as retrieving, creating, updating, and deleting user roles.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

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

    // Constructor - Initializes the logger and sender
    public UserRolesController(ILogger<UserRolesController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/UserRoles/GetAllUserRoles
    // Retrieves all user roles.
    [HttpGet]
    [Route("GetAllUserRoles")]
    [ProducesResponseType(typeof(List<UserRoleDto>), 200)]
    public async Task<List<UserRoleDto>> GetAllUserRoles()
    {
        return await _sender.Send(new GetUserRolesQuery());
    }

    // GET: api/UserRoles/GetByUserRolesId/{id}
    // Retrieves user role details by user role ID.
    [HttpGet]
    [Route("GetByUserRolesId/{id:Guid}")]
    [ProducesResponseType(typeof(UserRoleDetailDto), 200)]
    public async Task<UserRoleDetailDto> GetByUserRolesId(Guid id)
    {
        return await _sender.Send(new GetUserRoleDetailQuery(id));
    }

    // POST: api/UserRoles/CreateUserRoles
    // Creates a new user role.
    [HttpPost]
    [Route("CreateUserRoles")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateUserRoles(CreateUserRoleDto userRolesDto)
    {
        var result = await _sender.Send(new CreateUserRoleCommand(userRolesDto));
        return Ok(result);
    }

    // PUT: api/UserRoles/UpdateUserRoles
    // Updates an existing user role.
    [HttpPut]
    [Route("UpdateUserRoles")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateUserRoles(UserRoleDto userRolesDto)
    {
        var result = await _sender.Send(new UpdateUserRoleCommand(userRolesDto));
        return Ok(result);
    }

    // DELETE: api/UserRoles/DeleteUserRoles/{id}
    // Deletes a user role by user role ID.
    [HttpDelete]
    [Route("DeleteUserRoles/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteUserRoles(Guid id)
    {
        return await _sender.Send(new DeleteUserRoleCommand(id));
    }
}
