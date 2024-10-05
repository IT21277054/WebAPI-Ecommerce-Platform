using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public CreateUserHandler(IMapper mapper, IUserRepository userRepository)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;

    }
    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var UserToCreate = _mapper.Map<Domain.User>(request.dto);

        //add to database
        await _userRepository.CreateAsync(UserToCreate);

        //return record id
        return UserToCreate.Id;
    }
}
