using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
{
    public VendorRepository(EcommerceDBContext context) : base(context)
    {
    }
}
