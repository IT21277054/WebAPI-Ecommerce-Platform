using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;

public class CreateVendorFeedbackHandler : IRequestHandler<CreateVendorFeedbackCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IVendorFeedbackRepository _vendorFeedbackRepository;

    public CreateVendorFeedbackHandler(IMapper mapper, IVendorFeedbackRepository vendorFeedbackRepository)
    {
        this._mapper = mapper;
        this._vendorFeedbackRepository = vendorFeedbackRepository;

    }
    public async Task<int> Handle(CreateVendorFeedbackCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var VendorFeedbackToCreate = _mapper.Map<Domain.VendorFeedback>(request.dto);

        //add to database
        await _vendorFeedbackRepository.CreateAsync(VendorFeedbackToCreate);

        //return record id
        return VendorFeedbackToCreate.Id;
    }
}
