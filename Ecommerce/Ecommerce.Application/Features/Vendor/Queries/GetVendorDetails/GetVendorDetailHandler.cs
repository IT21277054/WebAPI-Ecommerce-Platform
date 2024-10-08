// ====================================================
// File: GetVendorDetailQueryHandler.cs (Corrected Class Name)
// Description: Handler for the GetVendorDetailQuery. Retrieves a specific vendor's details by ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetailQuery;

public class GetVendorDetailQueryHandler : IRequestHandler<GetVendorDetailQuery, VendorDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public GetVendorDetailQueryHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        _mapper = mapper;
        _vendorRepository = vendorRepository;
    }


    public async Task<VendorDetailDto> Handle(GetVendorDetailQuery request, CancellationToken cancellationToken)
    {
        // Fetch vendor details by ID from the vendor repository
        var vendorDetails = await _vendorRepository.GetByIdAsync(request.Id);

        // Validate incoming data (check if vendor exists)
        if (vendorDetails == null)
        {
            throw new NotFoundException(nameof(Vendor), request.Id); // Use "Vendor" for clarity
        }

        // Map vendor entity to VendorDetailDto
        var data = _mapper.Map<VendorDetailDto>(vendorDetails);

        // Return the vendor details DTO
        return data;
    }

}