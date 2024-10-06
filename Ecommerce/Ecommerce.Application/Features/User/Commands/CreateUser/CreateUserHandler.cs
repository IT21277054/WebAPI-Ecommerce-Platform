using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher<Domain.User> _passwordHasher;

    public CreateUserHandler(IMapper mapper, IUserRepository userRepository, IPasswordHasher<Domain.User> passwordHasher)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
        this._passwordHasher = passwordHasher;

    }
    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var userToCreate = _mapper.Map<Domain.User>(request.dto);

        userToCreate.Password = _passwordHasher.HashPassword(userToCreate, request.dto.Password);

        //add to database
        await _userRepository.CreateAsync(userToCreate);

        //return record id
        return userToCreate.Id;
    }
}
