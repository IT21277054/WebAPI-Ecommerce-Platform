using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole
{
    public class CreateUserRoleDto
    {
        public string Name { get; set; } = string.Empty;
        public string ValueCode { get; set; } = string.Empty;
    }
}
