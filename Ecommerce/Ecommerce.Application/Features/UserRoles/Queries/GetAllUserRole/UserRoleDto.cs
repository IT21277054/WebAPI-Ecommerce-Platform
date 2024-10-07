namespace Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;

public class UserRoleDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;
}
