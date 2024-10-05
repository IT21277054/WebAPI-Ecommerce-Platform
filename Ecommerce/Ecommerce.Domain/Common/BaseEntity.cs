using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Common;

public abstract class IBaseEntity 
{
    [Key]
    public int Id { get; set; }
    public bool? IsDeleted { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
    public int? ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
}
