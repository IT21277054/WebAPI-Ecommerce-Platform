using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;

namespace Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;

public class GetCatogeryDetailsHandler : IRequestHandler<GetCategoryDetailsQuery, CatgoryDetailsDto>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;

    public GetCatogeryDetailsHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;

    }


    public async Task<CatgoryDetailsDto> Handle(GetCategoryDetailsQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categoriesDetails = await _categoryRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoriesDetails == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        //convert data object to DTO objects
        var data = _mapper.Map<CatgoryDetailsDto>(categoriesDetails);

        //return list of Dto objects
        return data;
    }
}