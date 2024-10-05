using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.User.Commands.UpdateUser;
using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/UserProfile")]
public class UserController : ControllerBase
{

    private readonly ILogger<UserController> _logger;
    private readonly ISender _sender;

    public UserController(ILogger<UserController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet(Name = "GetAllUserProfile")]
    public async Task<List<UserDto>> GetAllUserProfile()
    {
        return await _sender.Send(new GetUserQuery());
    }

    [HttpPost(Name = "CreateUser")]
    public async Task<IActionResult> CreateUser(UserDto userDto)
    {
        var result = await _sender.Send(new CreateUserCommand(userDto));

        return Ok(new { Response = result });
    }

    [HttpPut(Name = "UpdateUser")]
    public async Task<IActionResult> UpdateUser(UserDto userDto)
    {
        var result = await _sender.Send(new UpdateUserCommmand(userDto));

        return Ok(result);

    }

    [HttpDelete(Name = "DeleteUser")]
    public async Task<List<UserDto>> DeleteUser()
    {
        return await _sender.Send(new GetUserQuery());
    }
}
