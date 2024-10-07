using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Cart.Commands.CreateCart
{
    public class CreateCartDto
    {
        public ICollection<CartItem> Items { get; set; }
        public Guid UserId { get; set; }
    }
}
