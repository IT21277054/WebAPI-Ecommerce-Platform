using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.CreateVendor;

public class CreateVendorHandler : IRequestHandler<CreateVendorCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public CreateVendorHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        this._mapper = mapper;
        this._vendorRepository = vendorRepository;

    }
    public async Task<int> Handle(CreateVendorCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var VendorToCreate = _mapper.Map<Domain.Vendor>(request.dto);

        //add to database
        await _vendorRepository.CreateAsync(VendorToCreate);

        //return record id
        return VendorToCreate.Id;
    }
}
