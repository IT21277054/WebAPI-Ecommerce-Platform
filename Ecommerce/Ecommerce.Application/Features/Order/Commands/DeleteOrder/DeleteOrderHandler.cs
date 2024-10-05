using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.DeleteOrder;

public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IOrderRepository _orderRepository;

    public DeleteOrderHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;

    }

    public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var OrderToDelete = await _orderRepository.GetByIdAsync(request.Id);

        //Validate incoming data

        //add to database
        await _orderRepository.DeleteAsync(OrderToDelete);

        //return record id
        return Unit.Value;
    }
}

