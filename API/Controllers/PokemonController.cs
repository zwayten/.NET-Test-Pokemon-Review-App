using Application.Services;
using Domain.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;
        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var pokemons = await _pokemonService.GetAllPokemon();
                return Ok(pokemons); 
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while fetching Pokémon data.");
            }
        }

        [HttpPost]
public async Task<IActionResult> AddPokemon(Pokemon pokemon)
{
    try
    {
         await _pokemonService.AddPokemon(pokemon);
        return Ok();
    }
    catch (Exception ex)
    {
        // Handle exceptions and return an appropriate error response
        return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding a Pokémon.");
    }
}
    }
}
