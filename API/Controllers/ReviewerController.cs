using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewerController : ControllerBase
    {
        private readonly IReviewerService _reviewerService;
        public ReviewerController(IReviewerService reviewerService) 
        {
            _reviewerService = reviewerService;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllRviewer()
        //{
        //    try
        //    {
        //        var reviewer = await _reviewerService.GetAll();
        //        return Ok(new { response = reviewer });
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exceptions and return an appropriate error response
        //        return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while fetching Reviewer data.");
        //    }
        //}

        //[HttpPost]
        //public IActionResult AddOwner(Reviewer reviewer)
        //{
        //    try
        //    {
        //        var o = _reviewerService.Add(reviewer);
        //        return Ok(o);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exceptions and return an appropriate error response
        //        return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while adding a reviewer. {ex.Message}");
        //    }
        //}
    }
}
