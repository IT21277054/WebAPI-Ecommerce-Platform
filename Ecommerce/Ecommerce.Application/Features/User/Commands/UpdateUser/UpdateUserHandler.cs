using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.UpdateUser;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommmand, int>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public UpdateUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;

    }
    public async Task<int> Handle(UpdateUserCommmand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var UserToUpdate = _mapper.Map<Domain.User>(request.dto);

        //add to database
        await _userRepository.UpdateAsync(UserToUpdate);

        //return record id
        return UserToUpdate.Id;
    }
}
