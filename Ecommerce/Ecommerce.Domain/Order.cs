using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Order : IBaseEntity
{
    public int Status { get; set; }
    public int[]? Items { get; set; }
    public int Amount { get; set; }

}
