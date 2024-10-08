// ====================================================
// File: CategoryController.cs
// Description: API controller for managing category operations 
//              such as getting, creating, updating, and deleting categories.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Category.Commands.CreateCategory;
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

    // Constructor - Initializes the logger and sender
    public CategoryController(ILogger<CategoryController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    // GET: api/category/GetAllCategories
    // Retrieves all categories.
    [HttpGet]
    [Route("GetAllCategories")]
    [ProducesResponseType(typeof(List<CategoryDto>), 200)]
    public async Task<List<CategoryDto>> GetAllCategories()
    {
        return await _sender.Send(new GetCategoriesQuery());
    }

    // GET: api/category/GetByCategoryId/{id}
    // Retrieves category details by ID.
    [HttpGet]
    [Route("GetByCategoryId/{id:int}")]
    [ProducesResponseType(typeof(CatgoryDetailsDto), 200)]
    public async Task<CatgoryDetailsDto> GetByCategoryId(int id)
    {
        return await _sender.Send(new GetCategoryDetailsQuery(id));
    }

    // POST: api/category/CreateCategory
    // Creates a new category.
    [HttpPost]
    [Route("CreateCategory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
    {
        var result = await _sender.Send(new CreateCategoryCommand(categoryDto));
        return Ok(new { id = result });
    }

    // PUT: api/category/UpdateCategory
    // Updates an existing category.
    [HttpPut]
    [Route("UpdateCategory")]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
    {
        var result = await _sender.Send(new UpdateCategoryCommand(categoryDto));
        return Ok(new { id = result });
    }

    // DELETE: api/category/DeleteCategory/{id}
    // Deletes a category by ID.
    [HttpDelete]
    [Route("DeleteCategory/{id:Guid}")]
    [ProducesResponseType(typeof(Unit), 200)]
    public async Task<Unit> DeleteCategory(int id)
    {
        return await _sender.Send(new DeleteCategoryCommand(id));
    }
}
