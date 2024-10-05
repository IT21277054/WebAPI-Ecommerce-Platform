using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Category : IBaseEntity
{
    public string Name { get; set; } = string.Empty;
}
