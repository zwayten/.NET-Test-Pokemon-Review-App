using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService  _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var countries = await _countryService.GetAllCountry();
                return Ok(countries);
            }catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while fetching countries data.");
            }
        }

        [HttpPost]
        public  IActionResult Add(Country country)
        {
            try
            {
                //await Console.Out.WriteLineAsync($"Adding a country {country.Name}");
                 var c = _countryService.AddCountry(country);
                return Ok(c);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding country data.");
            }
        }
    }
}
