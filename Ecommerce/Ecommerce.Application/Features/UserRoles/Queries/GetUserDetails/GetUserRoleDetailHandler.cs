// ====================================================
// File: GetUserRoleDetailHandler.cs (Incorrect Namespace)
// Description: (Description not applicable for this handler)
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

// **Corrected Namespace:**
namespace Ecommerce.Application.Features.User.Queries.GetUserDetails; // Assuming this handler retrieves user details

public class GetUserDetailsHandler : IRequestHandler<GetUserDetailQuery, UserDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetUserDetailsHandler(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }


    public async Task<UserDetailDto> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
    {
        // Fetch user details by ID from the user repository
        var userDetails = await _userRepository.GetByIdAsync(request.Id);

        // Validate incoming data (check if user exists)
        if (userDetails == null)
        {
            throw new NotFoundException(nameof(User), request.Id); // Use "User" for clarity
        }

        // Map user entity to UserDetailDto
        var data = _mapper.Map<UserDetailDto>(userDetails);

        // Return the user details DTO
        return data;
    }
}