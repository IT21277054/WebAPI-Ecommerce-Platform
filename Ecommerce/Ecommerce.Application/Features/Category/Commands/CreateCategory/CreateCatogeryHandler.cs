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
        // Convert domain entity object
        var categoryToCreate = _mapper.Map<Domain.Category>(request.dto);

        // Get the last ID from the database
        var lastCategory = await _categoryRepository.GetLastCategoryAsync();
        categoryToCreate.Id = (lastCategory != null) ? lastCategory.Id + 1 : 1;

        // Add to database
        await _categoryRepository.CreateAsync(categoryToCreate);

        // Return record id
        return categoryToCreate.Id;
    }
}
