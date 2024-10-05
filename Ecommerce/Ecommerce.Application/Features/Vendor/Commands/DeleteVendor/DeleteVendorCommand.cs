using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;

public class DeleteVendorCommand : IRequest<Unit>
{
    public int Id { get; set; }
}
