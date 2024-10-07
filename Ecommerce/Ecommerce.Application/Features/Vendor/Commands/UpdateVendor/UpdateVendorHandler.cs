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
        this._mapper = mapper;
        this._vendorRepository = vendorRepository;

    }
    public async Task<Guid> Handle(UpdateVendorCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var VendorToUpdate = _mapper.Map<Domain.Vendor>(request.dto);

        //add to database
        await _vendorRepository.UpdateAsync(VendorToUpdate);

        //return record id
        return VendorToUpdate.Id;
    }
}
