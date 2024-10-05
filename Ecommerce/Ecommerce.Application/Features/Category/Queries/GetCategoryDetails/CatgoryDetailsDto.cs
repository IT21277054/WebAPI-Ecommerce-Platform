namespace Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;

public class CatgoryDetailsDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
}
