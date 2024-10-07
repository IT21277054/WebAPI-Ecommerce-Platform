using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public class CreateProductCancellationHandler : IRequestHandler<CreateOrderCancellationCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IOrderCancelationRepository _orderCancellationRepository;

    public CreateProductCancellationHandler(IMapper mapper, IOrderCancelationRepository orderCancellationRepository)
    {
        this._mapper = mapper;
        this._orderCancellationRepository = orderCancellationRepository;

    }
    public async Task<Guid> Handle(CreateOrderCancellationCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var OrderCancellationToCreate = _mapper.Map<Domain.OrderCancelation>(request.dto);

        OrderCancellationToCreate.Id = Guid.NewGuid();

        //add to database
        await _orderCancellationRepository.CreateAsync(OrderCancellationToCreate);

        //return record id
        return OrderCancellationToCreate.Id;
    }
}
