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

    public async Task<Items> UpdateItemsByItemId(Items updatedItemData)
    {
        // Retrieve all orders from the database
        var orders = await _context.Set<Order>()
            .Include(o => o.Items) // Make sure to include the items in the orders
            .AsNoTracking()
            .ToListAsync();

        // Find the relevant item in the orders
        foreach (var order in orders)
        {
            var item = order.Items.FirstOrDefault(i => i.Id == updatedItemData.Id);

            if (item != null)
            {
                // Update the item's properties with the values from updatedItemData
                item.Amount = updatedItemData.Amount;
                item.Quantity = updatedItemData.Quantity;
                item.Status = updatedItemData.Status;
                item.VendorId = updatedItemData.VendorId;
                

                // Mark the order as modified
                _context.Update(order);
                await _context.SaveChangesAsync();

                // Return the updated item
                return item;
            }
        }

        // If no item was found, you might want to handle this case (e.g., throw an exception)
        throw new Exception("Item not found.");
    }





}
