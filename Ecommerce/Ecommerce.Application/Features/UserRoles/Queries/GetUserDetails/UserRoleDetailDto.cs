namespace Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;

public class UserRoleDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;
}
