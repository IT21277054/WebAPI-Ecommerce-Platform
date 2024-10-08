// ====================================================
// File: UpdateUserHandler.cs
// Description: Handler for the UpdateUserCommand. Updates a user in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.UpdateUser;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public UpdateUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
    }

    public async Task<Guid> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data (add validation logic here)

        // Convert DTO to domain entity object
        var userToUpdate = _mapper.Map<Domain.User>(request.dto);

        // Update user in the database
        await _userRepository.UpdateAsync(userToUpdate);

        // Return the updated user's ID
        return userToUpdate.Id;
    }
}