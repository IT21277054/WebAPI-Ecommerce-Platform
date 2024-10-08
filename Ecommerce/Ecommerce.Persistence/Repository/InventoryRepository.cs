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

        // Create a list of InventoryDto to hold the result
        var inventoryDtos = inventories.Select(inv => new InventoryDetailDto
        {
            Id = inv.Id,
            VendorId = inv.VendorId,
            VendorName = vendors.FirstOrDefault(v => v.Id == inv.VendorId)?.Name ?? string.Empty,
            CategoryId = inv.CategoryId,
            CategoryName = categories.FirstOrDefault(c => c.Id == inv.CategoryId)?.Name ?? string.Empty,
            ProductId = inv.ProductId,
            ProductName = products.FirstOrDefault(p => p.Id == inv.ProductId)?.Name ?? string.Empty,
            Description = inv.Description,
            UnitPrice = inv.UnitPrice,
            Quantity = inv.Quantity
        }).ToList();

        return inventoryDtos;
    }

}


    
