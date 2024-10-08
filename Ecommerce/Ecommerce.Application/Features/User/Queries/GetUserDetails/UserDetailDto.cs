﻿// ====================================================
// File: UserDetailDto.cs
// Description: Represents the data transfer object (DTO) for user details.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.User.Queries.GetUserDetails;

public class UserDetailDto
{
    public Guid Id { get; set; }
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