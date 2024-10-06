using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.DeleteUser;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public DeleteUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;

    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var UserToDelete = await _userRepository.GetByIdAsync(request.Id);

        //Validate incoming data


        //add to database
        await _userRepository.DeleteAsync(UserToDelete);

        //return record id
        return Unit.Value;
    }
}

