using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Exceptions;
using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Commands.DeleteCategory;

public class DeleteCatogeryHandler : IRequestHandler<DeleteCategoryCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;

    public DeleteCatogeryHandler(IMapper mapper, ICategoryRepository categoryRepository)
    {
        this._mapper = mapper;
        this._categoryRepository = categoryRepository;

    }

    public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        //retieve domain entity object
        var categoryToDelete = await _categoryRepository.GetByIdAsync(request.Id);

        //Validate incoming data
        if (categoryToDelete == null)
        {
            throw new NotFoundException(nameof(Category), request.Id);
        }

        //add to database
        await _categoryRepository.DeleteAsync(categoryToDelete);

        //return record id
        return Unit.Value;
    }
}
