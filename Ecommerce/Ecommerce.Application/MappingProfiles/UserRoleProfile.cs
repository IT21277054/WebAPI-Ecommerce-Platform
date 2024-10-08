// ====================================================
// File: UserRoleProfile.cs
// Description: AutoMapper profile for mapping UserRole entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;
using Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;
using Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class UserRoleProfile : Profile
{
    public UserRoleProfile()
    {
        // Map UserRoleDto to UserRoles and vice versa
        CreateMap<UserRoleDto, UserRoles>().ReverseMap();

        // Map UserRoleDetailDto to UserRoles and vice versa
        CreateMap<UserRoleDetailDto, UserRoles>().ReverseMap();

        // Map CreateUserRoleDto to UserRoles
        CreateMap<CreateUserRoleDto, UserRoles>();
    }
}
