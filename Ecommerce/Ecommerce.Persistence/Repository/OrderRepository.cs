// ====================================================
// File: OrderRepository.cs
// Description: Repository for managing order entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class OrderRepository : GenericRepository<Order, Guid>, IOrderRepository
{
    private readonly EcommerceDBContext _context;
    private readonly ICartRepository _cartRepository;
    private readonly IMapper _mapper;
    public OrderRepository(EcommerceDBContext context, ICartRepository cartRepository, IMapper mapper) : base(context)
    {
        _context = context; // Initialize the database context
        _cartRepository = cartRepository;
        _mapper = mapper;
    }

    public async Task<Order> GenerateOrder(string email)
    {
        // Fetch the cart based on the email
        var cart = await _cartRepository.GetCartByEmail(email);

        if (cart == null)
        {
            throw new Exception("Cart not found.");
        }

        // Map cart items to order items
        var orderItems = cart.Product.Select(item => new Items
        {
            ProductId = item.Id,
            VendorId = item.VendorId,
            Status = "Pending",
            Price = item.Price,
            Quantity = 1,
            Id = Guid.NewGuid(),
            CreatedOn = DateTime.UtcNow,
            ModifiedOn = DateTime.UtcNow
        }).ToList();

        // Create new order
        var order = new Order
        {
            Id = Guid.NewGuid(),
            CustomerEmail = cart.Email,
            Status = "Pending",
            Items = orderItems,
            Amount = orderItems.Sum(x => x.Price * x.Quantity),
            CreatedOn = DateTime.UtcNow,
            ModifiedOn = DateTime.UtcNow
        };

        // the new order using context
        _context.Order.Add(order); // Add the order to the Orders table

        var deleteCart = await _context.Cart.FirstOrDefaultAsync(c => c.Email == email);

        // Delete the cart using context
        _context.Cart.Remove(deleteCart);

        // Save changes to the database
        await _context.SaveChangesAsync();

        return order;
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
                item.Price = updatedItemData.Price;
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

    public async Task<Order?> GetOrderByEmail(string email)
    {
        return await _context.Set<Order>()
            .AsNoTracking()
            .FirstOrDefaultAsync(o => o.CustomerEmail == email);
    }

    public async Task<Items> CancelItem(Guid itemId)
    {
        // Retrieve all orders from the database
        var allOrders = await _context.Set<Order>()
            .Include(o => o.Items) 
            .AsNoTracking()        
            .ToListAsync();

        // Find the specific item in all orders
        var orderWithItem = allOrders.FirstOrDefault(order =>
            order.Items.Any(item => item.Id == itemId));

        if (orderWithItem == null)
        {
            throw new Exception("Item not found in any order");
        }

        // Get the item to cancel
        var itemToCancel = orderWithItem.Items.First(item => item.Id == itemId);

        // Update the status of the item
        itemToCancel.Status = "cancellation requested";

        // Re-attach the order to the context for updating
        _context.Set<Order>().Update(orderWithItem);

        // Save the changes
        await _context.SaveChangesAsync();

        // Return the updated item
        return itemToCancel;
    }

}
