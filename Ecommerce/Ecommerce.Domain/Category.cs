using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Category : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
}
