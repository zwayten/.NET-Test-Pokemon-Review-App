using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReveiwController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReveiwController(IReviewService reviewService)
        {
            _reviewService = reviewService;            
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(Review review)
        {
            var AddReview = _reviewService.AddReview(review);
            return Ok(AddReview);
        }
    }
}
