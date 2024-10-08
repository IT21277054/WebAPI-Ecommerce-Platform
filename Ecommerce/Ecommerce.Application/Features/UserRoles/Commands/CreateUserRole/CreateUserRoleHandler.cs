// ====================================================
// File: CreateUserRoleHandler.cs
// Description: Handler for the CreateUserRoleCommand. Creates a new user role and returns its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;

public class CreateUserRoleHandler : IRequestHandler<CreateUserRoleCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public CreateUserRoleHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        this._mapper = mapper;
        this._userRoleRepository = userRoleRepository;
    }

    public async Task<Guid> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        // Map CreateUserRoleDto to Domain.UserRoles entity
        var userRoleToCreate = _mapper.Map<Domain.UserRoles>(request.dto);

        // Generate a new GUID for the user role
        userRoleToCreate.Id = Guid.NewGuid();

        // Add the new user role to the database
        await _userRoleRepository.CreateAsync(userRoleToCreate);

        // Return the newly created user role ID
        return userRoleToCreate.Id;
    }
}