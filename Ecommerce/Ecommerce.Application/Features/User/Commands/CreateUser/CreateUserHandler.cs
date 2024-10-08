// ====================================================
// File: CreateUserHandler.cs
// Description: Command handler for creating a user.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher<Domain.User> _passwordHasher;

    // Constructor to inject dependencies
    public CreateUserHandler(IMapper mapper, IUserRepository userRepository, IPasswordHasher<Domain.User> passwordHasher)
    {
        this._mapper = mapper;
        this._userRepository = userRepository;
        this._passwordHasher = passwordHasher;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Check if email is null or empty
        if (string.IsNullOrEmpty(request.dto.Email))
        {
            throw new ArgumentException("Email cannot be null or empty.");
        }

        // Convert DTO to domain entity
        var userToCreate = _mapper.Map<Domain.User>(request.dto);

        userToCreate.Id = Guid.NewGuid();
        userToCreate.Password = _passwordHasher.HashPassword(userToCreate, request.dto.Password);

        // Add to database
        await _userRepository.CreateAsync(userToCreate);

        // Return record ID
        return userToCreate.Id;
    }
}
