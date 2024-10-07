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
        //Query the database
        var userDetail = await _userRepository.GetByIdAsync(request.Id);

        //Validate incoming data


        //convert data object to DTO objects
        var data = _mapper.Map<UserDetailDto>(userDetail);

        //return list of Dto objects
        return data;
    }
}
