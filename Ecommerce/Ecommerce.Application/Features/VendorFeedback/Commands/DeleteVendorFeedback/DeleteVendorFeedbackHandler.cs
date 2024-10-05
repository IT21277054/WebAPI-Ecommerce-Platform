using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.VendorFeedback.Commands.DeleteVendorFeedback;

public class DeleteVendorFeedbackHandler : IRequestHandler<DeleteVendorFeedbackCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IVendorFeedbackRepository _vendorFeedbackRepository;

    public DeleteVendorFeedbackHandler(IMapper mapper, IVendorFeedbackRepository vendorFeedbackRepository)
    {
        this._mapper = mapper;
        this._vendorFeedbackRepository = vendorFeedbackRepository;

    }

    public async Task<Unit> Handle(DeleteVendorFeedbackCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var VendorFeedbackToDelete = await _vendorFeedbackRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        //if (VendorFeedbackToDelete == null)
        //{
        //    throw new NotFoundException(nameof(VendorFeedback), request.Id);
        //}

        //add to database
        await _vendorFeedbackRepository.DeleteAsync(VendorFeedbackToDelete);

        //return record id
        return Unit.Value;
    }
}

