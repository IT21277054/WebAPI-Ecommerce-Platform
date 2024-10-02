using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain;

public class Order : BaseEntity
{
    public int Status { get; set; }
    public int[] Items { get; set; }


}
