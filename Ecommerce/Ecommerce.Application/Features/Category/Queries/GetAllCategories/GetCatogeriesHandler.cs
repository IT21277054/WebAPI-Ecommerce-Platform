using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Category.Queries.GetAllCategories;

public class GetCatogeriesHandler : IRequestHandler<GetCategoriesQuery, List<CategoryDto>>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;

    public GetCatogeriesHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;
        
    }

    public async Task<List<CategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var categories = await _categoryRepository.GetAsync();

        //convert data object to DTO objects
        var data = _mapper.Map<List<CategoryDto>>(categories);

        //return list of Dto objects
        return data;
    }
}
