using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;

public class CreateUserRoleHandler : IRequestHandler<CreateUserRoleCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public CreateUserRoleHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        this._mapper = mapper;
        this._userRoleRepository = userRoleRepository;

    }
    public async Task<Guid> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var UserRoleToCreate = _mapper.Map<Domain.UserRoles>(request.dto);

        UserRoleToCreate.Id = Guid.NewGuid();

        //add to database
        await _userRoleRepository.CreateAsync(UserRoleToCreate);

        //return record id
        return UserRoleToCreate.Id;
    }
}
