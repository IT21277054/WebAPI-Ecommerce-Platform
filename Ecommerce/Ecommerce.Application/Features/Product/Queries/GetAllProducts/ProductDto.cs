﻿// ====================================================
// File: ProductDto.cs
// Description: Data Transfer Object (DTO) for product details.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Product.Queries.GetAllProducts;

public class ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public Guid VendorId { get; set; }
    public bool IsActivated { get; set; } = false;
}
