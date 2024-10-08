// ====================================================
// File: OrderRepository.cs
// Description: Repository for managing order entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class OrderRepository : GenericRepository<Order, Guid>, IOrderRepository
{
    private readonly EcommerceDBContext _context;
    public OrderRepository(EcommerceDBContext context) : base(context)
    {
        _context = context; // Initialize the database context
    }

    public async Task<List<Items>> GetItemsByVendorId(Guid vendorId)
    {
        // Retrieve all orders from the repository asynchronously
        var allOrders = await _context.Set<Order>().AsNoTracking().ToListAsync();

        // Filter items based on the provided vendorId
        var vendorItems = allOrders
            .SelectMany(order => order.Items)
            .Where(item => item.VendorId == vendorId)
            .ToList();

        return vendorItems;
    }


}
