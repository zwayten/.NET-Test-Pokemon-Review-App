using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOwners()
        {
            try
            {
                var owners = await _ownerService.GetAllOwner();
                return Ok(new {response = owners});
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while fetching Owner data.");
            }
        }

        [HttpPost]
        public IActionResult AddOwner(Owner owner)
        {
            try
            {
                var o = _ownerService.AddOwner(owner);
                return Ok(o);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while adding a owner. {ex.Message}");
            }
        }
    }
}
