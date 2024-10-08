// ====================================================
// File: DeleteUserHandler.cs
// Description: Handler for processing user deletion requests.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.DeleteUser;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, UserDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public DeleteUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
    }

    public async Task<UserDto> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the user entity to delete
        var userToDelete = await _userRepository.DeleteByEmail(request.email);

        var deletedUser = _mapper.Map<UserDto>(userToDelete);

        // Return an empty response indicating the operation was successful
        return deletedUser;
    }
}
