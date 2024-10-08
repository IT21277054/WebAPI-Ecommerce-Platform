// ====================================================
// File: GetUserHandler.cs
// Description: Handler for the GetUserQuery. Retrieves all users from the database and returns them as DTOs.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetAllUsers;


public class GetUserHandler : IRequestHandler<GetUserQuery, List<UserDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
    }

    public async Task<List<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        // Fetch all users from the database
        var users = await _userRepository.GetAsync();

        // Map user entities to DTOs
        var data = _mapper.Map<List<UserDto>>(users);

        // Return the list of user DTOs
        return data;
    }
}