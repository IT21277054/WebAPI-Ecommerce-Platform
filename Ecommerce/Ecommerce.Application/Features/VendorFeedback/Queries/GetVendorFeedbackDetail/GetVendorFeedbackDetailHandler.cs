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
        //Query the database
        var categoriesDetails = await _vendorFeedbackRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(VendorFeedbackDetailDto), request.Id);
        }

        //convert data object to DTO objects
        var data = _mapper.Map<VendorFeedbackDetailDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}
