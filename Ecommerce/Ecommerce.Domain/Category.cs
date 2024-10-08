// ====================================================
// File: Category.cs
// Description: Entity representing a product category.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Category : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
}
