using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //Validate incoming data
        var validator = new CreateCategoryValidator();
        var  validationResult = await validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            throw new BadRequestException("Invalida category");
        }

        //convert domain entity object
        var categoryToCreate = _mapper.Map<Domain.Category>(request);

        //add to database
        await _categoryRepository.CreateAsync(categoryToCreate);

        //return record id
        return categoryToCreate.Id;
    }
}
