// ====================================================
// File: CartRepository.cs
// Description: Repository for managing cart entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Cart.Queries.GetCartDetails;
using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class CartRepository : GenericRepository<Cart, Guid>, ICartRepository
{
    private readonly EcommerceDBContext _context;

    public CartRepository(EcommerceDBContext context) : base(context)
    {
        _context = context;
    }

    public async Task<CartDetailDto> GetCartByEmail(string email)
    {
        // Fetch the cart for the user by email
        var cart = await _context.Cart.FirstOrDefaultAsync(c => c.Email == email);

        // If the cart is found
        if (cart != null)
        {
            // Fetch the relevant products based on the product IDs in the cart
            var productIds = cart.Product; // This is a Guid array
            var products = await _context.Product
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            // Calculate the total price
            var totalPrice = products.Sum(p => p.Price);

            // Create the CartDetailDto object to return
            return new CartDetailDto
            {
                Product = products.Select(p => new ProductDto // Map to ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Category = p.Category,
                    ImageUrl = p.ImageUrl,
                    VendorId = p.VendorId,
                    IsActivated = p.IsActivated
                }).ToList(),
                Email = cart.Email,
                TotalPrice = totalPrice
            };
        }

        // Return null or throw an exception if the cart is not found
        return null; // or throw new Exception("Cart not found");
    }



    public async Task<Cart> UpdateCart(string email, Product updatedProductData)
    {
        try
        {
            // Fetch the cart for the user by email
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.Email == email);

            // Check if the product exists in the Product collection
            var existingProduct = await _context.Product.AsNoTracking().FirstOrDefaultAsync(p => p.Id == updatedProductData.Id);


            // If the cart doesn't exist, create it and assign a new Guid
            if (cart == null)
            {
                cart = new Cart
                {
                    Id = Guid.NewGuid(), // Assign a new Guid
                    Email = email,
                    Product = new Guid[] { existingProduct.Id } // Initialize with the product Id
                };
                _context.Cart.Add(cart);
            }
            else
            {
                // Convert Product to a list for modification
                var itemsList = cart.Product?.ToList() ?? new List<Guid>();

                // Check if the product is already in the cart
                if (itemsList.Contains(existingProduct.Id))
                {
                    throw new Exception("Product already exists in the cart");
                }

                itemsList.Add(existingProduct.Id);
                cart.Product = itemsList.ToArray(); // Update the cart with the modified array
            }

            // Save the updated cart and related products
            await _context.SaveChangesAsync();
            return cart;
        }
        catch (Exception ex)
        {
            // Handle exceptions (logging, rethrowing, etc.)
            throw new Exception("Error updating cart", ex);
        }
    }















}
