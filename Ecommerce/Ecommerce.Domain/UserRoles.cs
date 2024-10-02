using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain;

public class UserRoles : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;

}
