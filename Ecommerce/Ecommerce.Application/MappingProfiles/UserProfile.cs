using AutoMapper;
using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
        CreateMap<User, UserDto>();
    }
}

