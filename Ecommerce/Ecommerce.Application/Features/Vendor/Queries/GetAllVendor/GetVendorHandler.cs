// ====================================================
// File: GetVendorListHandler.cs (Corrected Class Name)
// Description: Handler for the GetVendorQuery. Retrieves all vendors and returns them as DTOs.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;


public class GetVendorListHandler : IRequestHandler<GetVendorQuery, List<VendorDto>>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public GetVendorListHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        _mapper = mapper;
        _vendorRepository = vendorRepository;
    }

    public async Task<List<VendorDto>> Handle(GetVendorQuery request, CancellationToken cancellationToken)
    {
        // Fetch all vendors from the database
        var vendors = await _vendorRepository.GetAsync();

        // Map vendor entities to DTOs
        var data = _mapper.Map<List<VendorDto>>(vendors);

        // Return the list of vendor DTOs
        return data;
    }
}