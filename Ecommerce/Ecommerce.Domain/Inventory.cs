using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain;

public class Inventory : BaseEntity
{
    public int Amount { get; set; }
    public string Level { get; set; } = string.Empty;
    public bool IsAvailble { get; set; }

}
