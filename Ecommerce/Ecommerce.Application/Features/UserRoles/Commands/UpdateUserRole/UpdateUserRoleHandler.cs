using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.UpdateUserRole;

public class UpdateUserRoleHandler : IRequestHandler<UpdateUserRoleCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public UpdateUserRoleHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        this._mapper = mapper;
        this._userRoleRepository = userRoleRepository;

    }
    public async Task<int> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var UserRoleToUpdate = _mapper.Map<Domain.UserRoles>(request.dto);

        //add to database
        await _userRoleRepository.UpdateAsync(UserRoleToUpdate);

        //return record id
        return UserRoleToUpdate.Id;
    }
}
