using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Commands.UpdateCategory;

public class UpdateCatogeryHandler : IRequestHandler<UpdateCategoryCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;

    public UpdateCatogeryHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;

    }
    public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //convert domain entity object
        var categoryToUpdate = _mapper.Map<Domain.Category>(request);

        //add to database
        await _categoryRepository.UpdateAsync(categoryToUpdate);

        //return record id
        return Unit.Value;
    }
}
