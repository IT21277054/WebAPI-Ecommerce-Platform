using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.UpdateOrderCancellation;

public class UpdateOrderCancellationHandler : IRequestHandler<UpdateOrderCancellationCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IOrderCancelationRepository _OrderCancellationRepository;

    public UpdateOrderCancellationHandler(IMapper mapper, IOrderCancelationRepository OrderCancellationRepository)
    {
        this._mapper = mapper;
        this._OrderCancellationRepository = OrderCancellationRepository;

    }
    public async Task<int> Handle(UpdateOrderCancellationCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var OrderCancellationToUpdate = _mapper.Map<Domain.OrderCancelation>(request.dto);

        //add to database
        await _OrderCancellationRepository.UpdateAsync(OrderCancellationToUpdate);

        //return record id
        return OrderCancellationToUpdate.Id;
    }
}
