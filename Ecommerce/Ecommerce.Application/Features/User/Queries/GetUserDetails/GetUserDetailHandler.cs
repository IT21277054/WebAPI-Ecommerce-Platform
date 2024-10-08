// ====================================================
// File: GetUserDetailHandler.cs
// Description: Handler for the GetUserDetailQuery. Retrieves a specific user by ID and returns its details as a DTO.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetUserDetails;


public class GetUserDetailHandler : IRequestHandler<GetUserDetailQuery, UserDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetUserDetailHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
    }


    public async Task<UserDetailDto> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
    {
        // Fetch user details by ID
        var userDetail = await _userRepository.GetByIdAsync(request.Id);

        // Map user entity to DTO
        var data = _mapper.Map<UserDetailDto>(userDetail);

        // Return the user detail DTO
        return data;
    }
}