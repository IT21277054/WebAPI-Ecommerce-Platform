using Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using Ecommerce.Application.Features.User.Commands.DeleteUser;
using Ecommerce.Application.Features.User.Commands.UpdateUser;
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

    [HttpGet(Name = "GetAllUserProfile")]
    [ProducesResponseType(typeof(List<UserDto>), 200)]
    public async Task<List<UserDto>> GetAllUserProfile()
    {
        return await _sender.Send(new GetUserQuery());
    }

    [HttpGet("{id}", Name = "api/GetByUserId")]
    [ProducesResponseType(typeof(UserDetailDto), 200)]
    public async Task<UserDetailDto> GetByUserId(int id)
    {
        return await _sender.Send(new GetUserDetailQuery(id));
    }

    [HttpPost(Name = "CreateUser")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> CreateUser(UserDto userDto)
    {
        var result = await _sender.Send(new CreateUserCommand(userDto));

        return Ok(result);
    }

    [HttpPut(Name = "UpdateUser")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> UpdateUser(UserDto userDto)
    {
        var result = await _sender.Send(new UpdateUserCommmand(userDto));

        return Ok(result);

    }

    [HttpDelete("{id}", Name = "DeleteUser")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteUser(int id)
    {
        return await _sender.Send(new DeleteUserCommand(id));
    }
}
