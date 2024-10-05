using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain;

public class Vendor : User
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

}
