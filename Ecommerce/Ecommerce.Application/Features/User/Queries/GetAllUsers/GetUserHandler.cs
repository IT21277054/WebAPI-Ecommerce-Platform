using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetAllUsers;


public class GetUserHandler : IRequestHandler<GetUserQuery, List<UserDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetUserHandler(IMapper mapper, IUserRepository useryRepository)
    {
        this._mapper = mapper;
        this._userRepository = useryRepository;

    }

    public async Task<List<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _userRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<UserDto>>(categories);

        //return list of Dto objects
        return data;
    }
}
