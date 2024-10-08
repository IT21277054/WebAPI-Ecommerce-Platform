// ====================================================
// File: DeleteVendorFeedbackHandler.cs
// Description: Handler for the DeleteVendorFeedbackCommand. Deletes a vendor feedback by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions; // Import for NotFoundException
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;

public class DeleteVendorFeedbackHandler : IRequestHandler<DeleteVendorFeedbackCommand, Unit>
{
    private readonly IMapper _mapper; // Not used in this handler, but kept for consistency
    private readonly IVendorFeedbackRepository _vendorFeedbackRepository;

    public DeleteVendorFeedbackHandler(IMapper mapper, IVendorFeedbackRepository vendorFeedbackRepository)
    {
        _mapper = mapper;
        _vendorFeedbackRepository = vendorFeedbackRepository;
    }

    public async Task<Unit> Handle(DeleteVendorFeedbackCommand request, CancellationToken cancellationToken)
    {
        // Fetch the vendor feedback to delete by ID
        var vendorFeedbackToDelete = await _vendorFeedbackRepository.GetByIdAsync(request.Id);

        // (Optional) Add validation for incoming data (e.g., ensure a valid ID is provided)
        // Consider throwing a specific exception (NotFoundException) if the vendor feedback is not found.

        if (vendorFeedbackToDelete == null)
        {
            throw new NotFoundException(nameof(VendorFeedback), request.Id);
        }

        // Delete the vendor feedback from the database
        await _vendorFeedbackRepository.DeleteAsync(vendorFeedbackToDelete);

        // Since the return type is `Unit`, no specific value is returned to indicate success.

        return Unit.Value;
    }
}