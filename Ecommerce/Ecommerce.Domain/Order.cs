﻿using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Order : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    public string Status { get; set; } = string.Empty;
    public ICollection<Items> Items { get; set; }
    public double Amount { get; set; }

}

public class Items : BaseEntity<Guid>
{
    public string Status { get; set; } = string.Empty;
    public double Amount { get; set; }
    public int Quantity { get; set; }

}
