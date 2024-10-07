using AutoMapper;
using Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;
using Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class UserRoleProfile : Profile
{
    public UserRoleProfile()
    {
        CreateMap<UserRoleDto, UserRoles>().ReverseMap();
        CreateMap<CreateUserRoleDto, UserRoles>();
    }
}
