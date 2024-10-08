// ====================================================
// File: UpdateUserHandler.cs
// Description: Handler for the UpdateUserCommand. Updates a user in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.UpdateUser;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UserDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public UpdateUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
    }

    public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data (add validation logic here)

        // Convert DTO to domain entity object
        var userToUpdate = _mapper.Map<Domain.User>(request.dto);

        // Update user in the database
        var updatedUser = await _userRepository.UpdateByEmail(userToUpdate);

        var user = _mapper.Map<UserDto>(updatedUser);
        // Return the updated user's ID
        return user;
    }
}