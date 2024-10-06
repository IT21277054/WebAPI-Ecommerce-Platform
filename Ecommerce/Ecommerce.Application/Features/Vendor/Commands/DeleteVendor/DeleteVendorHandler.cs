using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Vendor.Commands.DeleteVendor;

public class DeleteVendorHandler : IRequestHandler<DeleteVendorCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IVendorRepository _vendorRepository;

    public DeleteVendorHandler(IMapper mapper, IVendorRepository vendorRepository)
    {
        this._mapper = mapper;
        this._vendorRepository = vendorRepository;

    }

    public async Task<Unit> Handle(DeleteVendorCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var VendorToDelete = await _vendorRepository.GetByIdAsync(request.Id);

        //Validate incoming data

        //add to database
        await _vendorRepository.DeleteAsync(VendorToDelete);

        //return record id
        return Unit.Value;
    }
}

