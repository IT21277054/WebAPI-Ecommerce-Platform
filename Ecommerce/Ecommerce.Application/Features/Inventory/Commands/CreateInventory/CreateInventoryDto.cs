using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Inventory.Commands.CreateInventory
{
    public class CreateInventoryDto
    {
        public int Amount { get; set; }
        public string Level { get; set; } = string.Empty;
        public string Catogery { get; set; } = string.Empty;
        public bool IsAvailble { get; set; }
    }
}
