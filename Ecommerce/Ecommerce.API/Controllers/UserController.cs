// ====================================================
// File: UserController.cs
// Description: API controller for managing user profile operations 
//              such as retrieving, creating, updating, deleting users, and user login.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.User.Commands.CreateUser;
using Ecommerce.Application.Features.User.Commands.DeleteUser;
using Ecommerce.Application.Features.User.Commands.UpdateUser;
using Ecommerce.Application.Features.User.LoginUser;
using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using Ecommerce.Application.Features.User.Queries.GetUserDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/UserProfile")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly ISender _sender;

    // Constructor - Initializes the logger and sender
    public UserController(ILogger<UserController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/UserProfile/GetAllUserProfile
    // Retrieves all user profiles.
    [HttpGet]
    [Route("GetAllUserProfile")]
    [ProducesResponseType(typeof(List<UserDto>), 200)]
    public async Task<IActionResult> GetAllUserProfile()
    {
        var result = await _sender.Send(new GetUserQuery());
        return Ok(new { data = result });
    }

    // GET: api/UserProfile/GetByUserId/{id}
    // Retrieves user details by user ID.
    [HttpGet]
    [Route("GetByUserbyEmail")]
    [ProducesResponseType(typeof(UserDetailDto), 200)]
    public async Task<IActionResult> GetByUserbyEmail(string email)
    {
        var result = await _sender.Send(new GetUserDetailQuery(email));
        return Ok(new { data = result });
    }

    // POST: api/UserProfile/CreateUser
    // Creates a new user profile.
    [HttpPost]
    [Route("CreateUser")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateUser(CreateUserDto userDto)
    {
        var result = await _sender.Send(new CreateUserCommand(userDto));
        return Ok(new { userId = result });
    }

    // POST: api/UserProfile/LoginUser
    // Authenticates a user and returns a token or message.
    [HttpPost]
    [Route("LoginUser")]
    [ProducesResponseType(typeof(string), 200)]
    public async Task<IActionResult> LoginUser(LoginUserDto userDto)
    {
        var result = await _sender.Send(new LoginUserCommand(userDto));
        return Ok(new { token = result });
    }

    // PUT: api/UserProfile/UpdateUser
    // Updates an existing user profile.
    [HttpPut]
    [Route("UpdateUser")]
    [ProducesResponseType(typeof(UserDto), 200)]
    public async Task<IActionResult> UpdateUser(UserDto userDto)
    {
        var result = await _sender.Send(new UpdateUserCommand(userDto));
        return Ok(new { data = result });
    }

    // DELETE: api/UserProfile/DeleteUser/{id}
    // Deletes a user profile by user ID.
    [HttpDelete]
    [Route("DeleteUser")]
    [ProducesResponseType(typeof(UserDto), 200)]
    public async Task<IActionResult> DeleteUser(string email)
    {
        await _sender.Send(new DeleteUserCommand(email));
        return Ok(new { message = "User deleted successfully." });
    }
}
