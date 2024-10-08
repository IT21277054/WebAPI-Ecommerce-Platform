// ====================================================
// File: UserProfile.cs
// Description: AutoMapper profile for mapping User entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Features.User.Commands.CreateUser;
using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using Ecommerce.Application.Features.User.Queries.GetUserDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        // Map UserDto to User and vice versa
        CreateMap<UserDto, User>().ReverseMap();

        // Map UserDetailDto to User and vice versa
        CreateMap<UserDetailDto, User>().ReverseMap();

        // Map CreateUserDto to User
        CreateMap<CreateUserDto, User>();
    }
}
