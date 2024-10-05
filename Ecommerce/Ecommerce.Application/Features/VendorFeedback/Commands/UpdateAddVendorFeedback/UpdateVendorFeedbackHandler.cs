using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.UpdateAddVendorFeedback;

public class UpdateVendorFeedbackHandler : IRequestHandler<UpdateVendorFeedbackCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IVendorFeedbackRepository _vendorFeedbackRepository;

    public UpdateVendorFeedbackHandler(IMapper mapper, IVendorFeedbackRepository vendorFeedbackRepository)
    {
        this._mapper = mapper;
        this._vendorFeedbackRepository = vendorFeedbackRepository;

    }
    public async Task<int> Handle(UpdateVendorFeedbackCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var VendorFeedbackToUpdate = _mapper.Map<Domain.VendorFeedback>(request.dto);

        //add to database
        await _vendorFeedbackRepository.UpdateAsync(VendorFeedbackToUpdate);

        //return record id
        return VendorFeedbackToUpdate.Id;
    }
}