// ====================================================
// File: UpdateVendorFeedbackHandler.cs
// Description: Handler for the UpdateVendorFeedbackCommand. Updates a vendor feedback using the provided DTO.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.UpdateAddVendorFeedback;

public class UpdateVendorFeedbackHandler : IRequestHandler<UpdateVendorFeedbackCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IVendorFeedbackRepository _vendorFeedbackRepository;

    public UpdateVendorFeedbackHandler(IMapper mapper, IVendorFeedbackRepository vendorFeedbackRepository)
    {
        this._mapper = mapper;
        this._vendorFeedbackRepository = vendorFeedbackRepository;
    }

    public async Task<Guid> Handle(UpdateVendorFeedbackCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data (add validation logic here)

        // Convert the DTO (Data Transfer Object) to the domain entity object
        var vendorFeedbackToUpdate = _mapper.Map<Domain.VendorFeedback>(request.dto);

        // Update the vendor feedback in the database
        await _vendorFeedbackRepository.UpdateAsync(vendorFeedbackToUpdate);

        // Return the ID of the updated vendor feedback record
        return vendorFeedbackToUpdate.Id;
    }
}