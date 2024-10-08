// ====================================================
// File: GetUserRolesHandler.cs
// Description: Handler for the GetUserRolesQuery. Retrieves all user roles and returns them as DTOs.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;


public class GetUserRolesHandler : IRequestHandler<GetUserRolesQuery, List<UserRoleDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public GetUserRolesHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        _mapper = mapper;
        _userRoleRepository = userRoleRepository;
    }

    public async Task<List<UserRoleDto>> Handle(GetUserRolesQuery request, CancellationToken cancellationToken)
    {
        // Fetch all user roles from the database
        var userRoles = await _userRoleRepository.GetAsync();

        // Map user role entities to DTOs
        var data = _mapper.Map<List<UserRoleDto>>(userRoles);

        // Return the list of user role DTOs
        return data;
    }
}