using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Queries.GetVendorDetails;

public class GetVendorDetailHandler : IRequestHandler<GetVendorDetailQuery, VendorDetailDto>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public GetVendorDetailHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        this._mapper = mapper;
        this._vendorRepository = vendorRepository;

    }


    public async Task<VendorDetailDto> Handle(GetVendorDetailQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categoriesDetails = await _vendorRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Vendor), request.Id);
        }

        //convert data object to DTO objects
        var data = _mapper.Map<VendorDetailDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}
