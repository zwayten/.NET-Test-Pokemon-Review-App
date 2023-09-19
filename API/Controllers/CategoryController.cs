using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                   
                var categories = await _categoryService.GetAllCategory();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while fetching Category data.{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            try
            {
                
                await _categoryService.AddCategory(category);
                return Ok();
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding a category.");
            }
        }
    }
}
