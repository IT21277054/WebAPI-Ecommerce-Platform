using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
{
    private readonly EcommerceDBContext _context;

    public CategoryRepository(EcommerceDBContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Category> GetLastCategoryAsync()
    {
        // Use the _context to access the Categories DbSet
        return await _context.Category.OrderByDescending(c => c.Id).FirstOrDefaultAsync();
    }
}