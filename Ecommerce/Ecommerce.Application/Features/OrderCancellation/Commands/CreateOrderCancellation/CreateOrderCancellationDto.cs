using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation
{
    public class CreateOrderCancellationDto
    {
        public string Topic { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public Guid OrderId { get; set; }
    }
}
