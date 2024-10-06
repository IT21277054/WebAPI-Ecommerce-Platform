using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Commands.DeleteCart;

public class DeleteCartHandler : IRequestHandler<DeleteCartCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ICartRepository _cartRepository;

    public DeleteCartHandler(IMapper mapper, ICartRepository cartRepository)
    {
        this._mapper = mapper;
        this._cartRepository = cartRepository;

    }

    public async Task<Unit> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var categoryToDelete = await _cartRepository.GetByIdAsync(request.Id);

        //Validate incoming data

        //add to database
        await _cartRepository.DeleteAsync(categoryToDelete);

        //return record id
        return Unit.Value;
    }
}
