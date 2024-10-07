using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Commands.DeleteCategory;
using Ecommerce.Application.Features.Category.Commands.UpdateCategory;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/category")]
public class CategoryController : ControllerBase
{

    private readonly ILogger<CategoryController> _logger;
    private readonly ISender _sender;

    public CategoryController(ILogger<CategoryController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet]
    [Route("GetAllCategories")]
    [ProducesResponseType(typeof(List<CategoryDto>), 200)]
    public async Task<List<CategoryDto>> GetAllCategories()
    {
        return await _sender.Send(new GetCategoriesQuery());
    }

    [HttpGet]
    [Route("GetByCategoryId/{id:int}")]
    [ProducesResponseType(typeof(CatgoryDetailsDto), 200)]
    public async Task<CatgoryDetailsDto> GetByCategoryId(int id)
    {
        return await _sender.Send(new GetCategoryDetailsQuery(id));
    }

    [HttpPost]
    [Route("CreateCategory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
    {
        var result = await _sender.Send(new CreateCategoryCommand(categoryDto));

        return Ok(result);
    }

    [HttpPut]
    [Route("UpdateCategory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
    {
        var result = await _sender.Send(new UpdateCategoryCommand(categoryDto));

        return Ok(result);

    }

    [HttpDelete]
    [Route("DeleteCategory/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteCategory(int id)
    {
        return await _sender.Send(new DeleteCategoryCommand(id));
    }
}
