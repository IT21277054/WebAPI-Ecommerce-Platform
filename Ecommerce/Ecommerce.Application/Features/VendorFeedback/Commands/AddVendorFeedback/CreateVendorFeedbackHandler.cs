// ====================================================
// File: CreateVendorFeedbackHandler.cs
// Description: Handler for the CreateVendorFeedbackCommand. Creates a new vendor feedback and returns its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;

public class CreateVendorFeedbackHandler : IRequestHandler<CreateVendorFeedbackCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IVendorFeedbackRepository _vendorFeedbackRepository;

    public CreateVendorFeedbackHandler(IMapper mapper, IVendorFeedbackRepository vendorFeedbackRepository)
    {
        _mapper = mapper;
        _vendorFeedbackRepository = vendorFeedbackRepository;
    }

    public async Task<Guid> Handle(CreateVendorFeedbackCommand request, CancellationToken cancellationToken)
    {
        // Map CreateVendorFeedbackDto to a Domain.VendorFeedback entity
        var vendorFeedbackToCreate = _mapper.Map<Domain.VendorFeedback>(request.dto);

        // Generate a new GUID for the vendor feedback
        vendorFeedbackToCreate.Id = Guid.NewGuid();

        // Add the new vendor feedback to the database
        await _vendorFeedbackRepository.CreateAsync(vendorFeedbackToCreate);

        // Return the newly created vendor feedback ID
        return vendorFeedbackToCreate.Id;
    }
}