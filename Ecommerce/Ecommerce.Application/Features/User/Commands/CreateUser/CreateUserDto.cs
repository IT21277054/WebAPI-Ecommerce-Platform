namespace Ecommerce.Application.Features.User.Commands.CreateUser;

public class CreateUserDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string UserRole { get; set; } = string.Empty;
    public bool isActivated { get; set; } = false;
}
