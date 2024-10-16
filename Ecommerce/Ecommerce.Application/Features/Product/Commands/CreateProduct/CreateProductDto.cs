﻿// ====================================================
// File: CreateProductDto.cs
// Description: Data Transfer Object (DTO) for creating a new product.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

namespace Ecommerce.Application.Features.Product.Commands.CreateProduct;

public class CreateProductDto
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public Guid? VendorId { get; set; }
    public bool IsActivated { get; set; } = false;
}
