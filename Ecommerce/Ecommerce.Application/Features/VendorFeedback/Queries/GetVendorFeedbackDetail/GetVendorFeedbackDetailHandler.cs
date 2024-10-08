// ====================================================
// File: GetVendorFeedbackDetailHandler.cs
// Description: Handler for the GetVendorFeedbackDetailQuery. Retrieves a specific vendor feedback by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;

public class GetVendorFeedbackDetailHandler : IRequestHandler<GetVendorFeedbackDetailQuery, VendorFeedbackDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IVendorFeedbackRepository _vendorFeedbackRepository;

    public GetVendorFeedbackDetailHandler(IMapper mapper, IVendorFeedbackRepository vendorFeedbackRepository)
    {
        this._mapper = mapper;
        this._vendorFeedbackRepository = vendorFeedbackRepository;
    }

    public async Task<VendorFeedbackDetailDto> Handle(GetVendorFeedbackDetailQuery request, CancellationToken cancellationToken)
    {
        // Query the database to retrieve the vendor feedback with the specified ID
        var vendorFeedbackDetails = await _vendorFeedbackRepository.GetByIdAsync(request.Id);

        // Validate if the vendor feedback exists
        if (vendorFeedbackDetails == null)
        {
            throw new NotFoundException(nameof(VendorFeedbackDetailDto), request.Id);
        }

        // Convert the retrieved vendor feedback entity to a DTO object
        var data = _mapper.Map<VendorFeedbackDetailDto>(vendorFeedbackDetails);

        // Return the DTO object representing the detailed vendor feedback
        return data;
    }
}