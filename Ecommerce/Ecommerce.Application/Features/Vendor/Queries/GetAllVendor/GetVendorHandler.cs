using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;


public class GetVendorHandler : IRequestHandler<GetVendorQuery, List<VendorDto>>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public GetVendorHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        this._mapper = mapper;
        this._vendorRepository = vendorRepository;

    }

    public async Task<List<VendorDto>> Handle(GetVendorQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _vendorRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<VendorDto>>(categories);

        //return list of Dto objects
        return data;
    }
}
