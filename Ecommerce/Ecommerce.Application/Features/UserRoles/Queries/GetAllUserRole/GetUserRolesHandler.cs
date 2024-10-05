using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;


public class GetUserRolesHandler : IRequestHandler<GetUserRolesQuery, List<UserRoleDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRolesRepository _userRoleRepository;

    public GetUserRolesHandler(IMapper mapper, IUserRolesRepository userRoleRepository)
    {
        this._mapper = mapper;
        this._userRoleRepository = userRoleRepository;

    }

    public async Task<List<UserRoleDto>> Handle(GetUserRolesQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _userRoleRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<UserRoleDto>>(categories);

        //return list of Dto objects
        return data;
    }
}
