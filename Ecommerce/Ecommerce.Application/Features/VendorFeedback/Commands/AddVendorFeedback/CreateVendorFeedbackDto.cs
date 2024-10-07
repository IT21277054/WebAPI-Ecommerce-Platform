using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback
{
    public class CreateVendorFeedbackDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid ProductId { get; set; }
        public Guid Rate { get; set; }
        public Guid VendorId { get; set; }
    }
}
