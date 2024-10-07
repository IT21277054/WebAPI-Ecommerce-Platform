using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Cart.Queries.GetCartDetails;

public class GetCartHandler : IRequestHandler<GetCartDetailsQuery, CartDetailDto>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;

    public GetCartHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;

    }


    public async Task<CartDetailDto> Handle(GetCartDetailsQuery request, CancellationToken cancellationToken)
    {
        throw new NotFoundException(nameof(Cart), request.Id);

        //Validate incoming data
        //if (categoriesDetails == null)
        //{
        //    throw new NotFoundException(nameof(Cart), request.Id);
        //}

        //convert data object to DTO objects

        //return list of Dto objects
    }
}
