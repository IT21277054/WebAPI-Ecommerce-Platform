using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using MediatR;

namespace Ecommerce.Application.Features.Order.Commands.CancelItem;

public class CancelItemHandler : IRequestHandler<CancelItemCommand, ItemsDto>
{
    private readonly IMapper _mapper; // AutoMapper for object mapping
    private readonly IOrderRepository _orderRepository; // Repository for order operations

    public CancelItemHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        this._mapper = mapper;
        this._orderRepository = orderRepository;
    }

    public async Task<ItemsDto> Handle(CancelItemCommand request, CancellationToken cancellationToken)
    {

        // Add to database
        var itema = await _orderRepository.CancelItem(request.id);

        var data = _mapper.Map<ItemsDto>(itema);

        // Return record id
        return data;
    }
}
