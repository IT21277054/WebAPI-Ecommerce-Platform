using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory;

public class CreateCatogeryHandler : IRequestHandler<CreateCategoryCommand, int>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;

    public CreateCatogeryHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;

    }
    public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        //convert domain entity object
        var categoryToCreate = _mapper.Map<Domain.Category>(request.dto);

        //add to database
        await _categoryRepository.CreateAsync(categoryToCreate);

        //return record id
        return categoryToCreate.Id;
    }
}
