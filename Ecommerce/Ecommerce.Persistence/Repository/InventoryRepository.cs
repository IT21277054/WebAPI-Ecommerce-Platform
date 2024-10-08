// ====================================================
// File: InventoryRepository.cs
// Description: Repository for managing inventory entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class InventoryRepository : GenericRepository<Inventory, Guid>, IInventoryRepository
{
    private readonly EcommerceDBContext _context;
    public InventoryRepository(EcommerceDBContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<InventoryDetailDto>> GetAllInventory()
    {
        // Fetch all inventories from the database
        var inventories = await _context.Set<Inventory>().AsNoTracking().ToListAsync();

        // Fetch all vendors, categories, and products in parallel to improve performance
        var vendors = await _context.Set<User>().AsNoTracking().ToListAsync();
        var categories = await _context.Set<Category>().AsNoTracking().ToListAsync();
        var products = await _context.Set<Product>().AsNoTracking().ToListAsync();

        // Create dictionaries for faster lookups
        var vendorDictionary = vendors.ToDictionary(v => v.Id, v => v.Name);
        var categoryDictionary = categories.ToDictionary(c => c.Id, c => c.Name);
        var productDictionary = products.ToDictionary(p => p.Id, p => new { p.Name, p.VendorId }); // Store Name and VendorId

        // Create a list of InventoryDetailDto to hold the result
        var inventoryDtos = inventories.Select(inv => new InventoryDetailDto
        {
            Id = inv.Id,
            VendorId = productDictionary.TryGetValue(inv.ProductId, out var productDetails) ? productDetails.VendorId : Guid.Empty,
            VendorName = productDictionary.TryGetValue(inv.ProductId, out productDetails) ? vendorDictionary.GetValueOrDefault(productDetails.VendorId, string.Empty) : string.Empty,
            CategoryId = inv.CategoryId,
            CategoryName = categoryDictionary.TryGetValue(inv.CategoryId, out var categoryName) ? categoryName : string.Empty,
            ProductId = inv.ProductId,
            ProductName = productDictionary.TryGetValue(inv.ProductId, out productDetails) ? productDetails.Name : string.Empty,
            Description = inv.Description,
            UnitPrice = inv.UnitPrice,
            Quantity = inv.Quantity
        }).ToList();

        return inventoryDtos;
    }


}



