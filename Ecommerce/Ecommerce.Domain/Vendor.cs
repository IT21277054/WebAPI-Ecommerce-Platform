﻿using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Vendor : IBaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;

}
