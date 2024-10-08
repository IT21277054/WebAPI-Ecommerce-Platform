// ====================================================
// File: GetVendorFeedbackHandler.cs
// Description: Handler for the GetVendorFeedbackQuery. Retrieves all vendor feedbacks from the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;

public class GetVendorFeedbackHandler : IRequestHandler<GetVendorFeedbackQuery, List<VendorFeedbackDto>>
{
    private readonly IMapper _mapper;
    private readonly IVendorFeedbackRepository _vendorRepository;

    public GetVendorFeedbackHandler(IMapper mapper, IVendorFeedbackRepository vendorRepository)
    {
        this._mapper = mapper;
        this._vendorRepository = vendorRepository;
    }

    public async Task<List<VendorFeedbackDto>> Handle(GetVendorFeedbackQuery request, CancellationToken cancellationToken)
    {
        // Query the database to retrieve all vendor feedbacks
        var vendorFeedbacks = await _vendorRepository.GetAsync();

        // Convert the retrieved vendor feedback entities to a list of DTO objects
        var data = _mapper.Map<List<VendorFeedbackDto>>(vendorFeedbacks);

        // Return the list of DTO objects representing the vendor feedbacks
        return data;
    }
}