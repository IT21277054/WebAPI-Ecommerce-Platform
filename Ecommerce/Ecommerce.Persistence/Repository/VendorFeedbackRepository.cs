using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class VendorFeedbackRepository : GenericRepository<VendorFeedback>, IVendorFeedbackRepository
{
    public VendorFeedbackRepository(EcommerceDBContext context) : base(context)
    {
    }
}
