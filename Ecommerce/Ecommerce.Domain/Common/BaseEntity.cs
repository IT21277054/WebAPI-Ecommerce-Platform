﻿// ====================================================
// File: BaseEntity.cs
// Description: Base entity class for common properties across entities.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Common;

public abstract class BaseEntity<T> : IEntity
{
    [Key]
    public T Id { get; set; }
    public bool? IsDeleted { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
}

public interface IEntity
{
    public Guid? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
}
