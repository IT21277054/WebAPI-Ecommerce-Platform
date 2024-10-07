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

    public UserController(ILogger<UserController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet]
    [Route("GetAllUserProfile")]
    [ProducesResponseType(typeof(List<UserDto>), 200)]
    public async Task<List<UserDto>> GetAllUserProfile()
    {
        return await _sender.Send(new GetUserQuery());
    }

    [HttpGet]
    [Route("GetByUserId/{id:Guid}")]
    [ProducesResponseType(typeof(UserDetailDto), 200)]
    public async Task<UserDetailDto> GetByUserId(Guid id)
    {
        return await _sender.Send(new GetUserDetailQuery(id));
    }

    [HttpPost]
    [Route("CreateUser")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateUser(CreateUserDto userDto)
    {
        var result = await _sender.Send(new CreateUserCommand(userDto));

        return Ok(result);
    }

    [HttpPost]
    [Route("LoginUser")]
    [ProducesResponseType(typeof(string), 200)]
    public async Task<IActionResult> LoginUser(LoginUserDto userDto)
    {
        var result = await _sender.Send(new LoginUserCommand(userDto));

        return Ok(result);
    }

    [HttpPut]
    [Route("UpdateUser")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateUser(UserDto userDto)
    {
        var result = await _sender.Send(new UpdateUserCommmand(userDto));

        return Ok(result);

    }

    [HttpDelete]
    [Route("DeleteUser/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteUser(Guid id)
    {
        return await _sender.Send(new DeleteUserCommand(id));
    }
}
