﻿using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
}
