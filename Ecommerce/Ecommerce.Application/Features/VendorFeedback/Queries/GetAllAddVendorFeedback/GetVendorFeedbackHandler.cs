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
        //Query the database
        var categories = await _vendorRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<VendorFeedbackDto>>(categories);

        //return list of Dto objects
        return data;
    }
}
