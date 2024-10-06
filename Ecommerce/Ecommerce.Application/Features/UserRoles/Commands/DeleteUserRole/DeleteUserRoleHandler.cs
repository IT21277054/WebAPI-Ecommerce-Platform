using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.DeleteUserRole;

public class DeleteUserRoleHandler : IRequestHandler<DeleteUserRoleCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public DeleteUserRoleHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        this._mapper = mapper;
        this._userRoleRepository = userRoleRepository;

    }

    public async Task<Unit> Handle(DeleteUserRoleCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var UserRoleToDelete = await _userRoleRepository.GetByIdAsync(request.Id);

        //Validate incoming data

        //add to database
        await _userRoleRepository.DeleteAsync(UserRoleToDelete);

        //return record id
        return Unit.Value;
    }
}

