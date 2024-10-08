// ====================================================
// File: DeleteUserRoleHandler.cs
// Description: Handler for the DeleteUserRoleCommand. Deletes a user role by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.DeleteUserRole;

public class DeleteUserRoleHandler : IRequestHandler<DeleteUserRoleCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public DeleteUserRoleHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        this._mapper = mapper;
        this._userRoleRepository = userRoleRepository;
    }

    public async Task<Unit> Handle(DeleteUserRoleCommand request, CancellationToken cancellationToken)
    {
        // Fetch the user role to delete by ID
        var userRoleToDelete = await _userRoleRepository.GetByIdAsync(request.Id);

        // If the user role is not found, consider throwing a specific exception to indicate this error.

        // Delete the user role from the database
        await _userRoleRepository.DeleteAsync(userRoleToDelete);

        // Since the return type is `Unit`, no specific value is returned to indicate success.

        return Unit.Value;
    }
}