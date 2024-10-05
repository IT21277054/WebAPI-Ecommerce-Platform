using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.DeleteUserRole;

public class DeleteUserRoleCommand : IRequest<Unit>
{
    public int Id { get; set; }
}
