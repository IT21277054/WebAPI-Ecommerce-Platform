// ====================================================
// File: DeleteUserHandler.cs
// Description: Handler for processing user deletion requests.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.DeleteUser;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public DeleteUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the user entity to delete
        var userToDelete = await _userRepository.GetByIdAsync(request.Id);

        // Validate incoming data (optional validation logic can be added here)

        // Delete the user from the database
        await _userRepository.DeleteAsync(userToDelete);

        // Return an empty response indicating the operation was successful
        return Unit.Value;
    }
}
