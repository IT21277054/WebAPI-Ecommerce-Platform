// ====================================================
// File: DeleteVendorHandler.cs
// Description: Handler for the DeleteVendorCommand. Deletes a vendor by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;

public class DeleteVendorHandler : IRequestHandler<DeleteVendorCommand, Unit>
{
    private readonly IMapper _mapper; // Not used in this handler, but kept for consistency
    private readonly IVendorRepository _vendorRepository;

    public DeleteVendorHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        _mapper = mapper;
        _vendorRepository = vendorRepository;
    }

    public async Task<Unit> Handle(DeleteVendorCommand request, CancellationToken cancellationToken)
    {
        // Fetch the vendor to delete by ID
        var vendorToDelete = await _vendorRepository.GetByIdAsync(request.Id);

        // (Optional) Add validation for incoming data (e.g., ensure a valid ID is provided)
        // If the vendor is not found, consider throwing a specific exception to indicate this error.

        // Delete the vendor from the database
        await _vendorRepository.DeleteAsync(vendorToDelete);

        // Since the return type is `Unit`, no specific value is returned to indicate success.

        return Unit.Value;
    }
}