using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Commands.DeleteCategory;
using Ecommerce.Application.Features.Category.Commands.UpdateCategory;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
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

    [HttpGet(Name = "api/GetAllCategories")]
    public async Task<List<CategoryDto>> GetAllCategories()
    {
        return await _sender.Send(new GetCategoriesQuery());
    }

    [HttpPost(Name = "api/CreateCategory")]
    public async Task<IActionResult> CreateCategory(CategoryDto categoryDto)
    {
        var result = await _sender.Send(new CreateCategoryCommand(categoryDto));

        return Ok(result);
    }

    [HttpPut(Name = "api/UpdateCategory")]
    public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
    {
        var result = await _sender.Send(new UpdateCategoryCommand(categoryDto));

        return Ok(result);

    }

    [HttpDelete(Name = "api/DeleteCategory")]
    public async Task<Unit> DeleteCategory()
    {
        return await _sender.Send(new DeleteCategoryCommand());
    }
}
