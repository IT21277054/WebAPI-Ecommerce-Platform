using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
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
        var categoriesDetails = await _userRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        //convert data object to DTO objects
        var data = _mapper.Map<UserDetailDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}
