using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;

public class DeleteOrderCancellationHandler : IRequestHandler<DeleteOrderCancellationCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IOrderCancelationRepository _orderCancellationRepository;

    public DeleteOrderCancellationHandler(IMapper mapper, IOrderCancelationRepository orderCancellationRepository)
    {
        this._mapper = mapper;
        this._orderCancellationRepository = orderCancellationRepository;

    }

    public async Task<Unit> Handle(DeleteOrderCancellationCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var OrderCancellationToDelete = await _orderCancellationRepository.GetByIdAsync(request.Id);

        //Validate incoming data

        //add to database
        await _orderCancellationRepository.DeleteAsync(OrderCancellationToDelete);

        //return record id
        return Unit.Value;
    }
}

