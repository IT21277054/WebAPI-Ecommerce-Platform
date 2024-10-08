// ====================================================
// File: UpdateUserRoleHandler.cs
// Description: Handler for the UpdateUserRoleCommand. Updates a user role and returns its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.UpdateUserRole;

public class UpdateUserRoleHandler : IRequestHandler<UpdateUserRoleCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public UpdateUserRoleHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        _mapper = mapper;
        _userRoleRepository = userRoleRepository;
    }

    public async Task<Guid> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
    {
        // Map UpdateUserRoleDto to Domain.UserRoles entity
        var userRoleToUpdate = _mapper.Map<Domain.UserRoles>(request.dto);

        // Update the user role in the database
        await _userRoleRepository.UpdateAsync(userRoleToUpdate);

        // Return the updated user role ID
        return userRoleToUpdate.Id;
    }
}