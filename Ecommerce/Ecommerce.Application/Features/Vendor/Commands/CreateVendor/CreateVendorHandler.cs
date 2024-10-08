// ====================================================
// File: CreateVendorHandler.cs
// Description: Handler for the CreateVendorCommand. Creates a new vendor and returns its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public class CreateVendorHandler : IRequestHandler<CreateVendorCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public CreateVendorHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        _mapper = mapper;
        _vendorRepository = vendorRepository;
    }

    public async Task<Guid> Handle(CreateVendorCommand request, CancellationToken cancellationToken)
    {
        // Map CreateVendorDto to Domain.Vendor entity
        var vendorToCreate = _mapper.Map<Domain.Vendor>(request.dto);

        // Generate a new GUID for the vendor
        vendorToCreate.Id = Guid.NewGuid();

        // Add the new vendor to the database
        await _vendorRepository.CreateAsync(vendorToCreate);

        // Return the newly created vendor ID
        return vendorToCreate.Id;
    }
}