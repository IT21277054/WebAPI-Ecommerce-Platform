// ====================================================
// File: UpdateVendorHandler.cs
// Description: Handler for the UpdateVendorCommand. Updates a vendor and returns its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.UpdateVendor;

public class UpdateVendorHandler : IRequestHandler<UpdateVendorCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public UpdateVendorHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        _mapper = mapper;
        _vendorRepository = vendorRepository;
    }

    public async Task<Guid> Handle(UpdateVendorCommand request, CancellationToken cancellationToken)
    {
        // (Optional) Validate incoming data (e.g., ensure required fields are provided)

        // Map UpdateVendorDto to Domain.Vendor entity
        var vendorToUpdate = _mapper.Map<Domain.Vendor>(request.dto);

        // Update the vendor in the database
        await _vendorRepository.UpdateAsync(vendorToUpdate);

        // Return the updated vendor ID
        return vendorToUpdate.Id;
    }
}