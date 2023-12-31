﻿using Application.Services;
using Domain.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                return Ok(new {response = pokemons}); 
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while fetching Pokémon data.");
            }
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneById(int id)
        {
            try
            {
                var pokemon = await _pokemonService.GetPokemonById(id);
                if(pokemon == null)
                {
                    return NotFound();
                }
                return Ok(new { response = pokemon });
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
                return Ok(new {response = pokemon});
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding a Pokémon.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePokemon(int id)
        {
            try
            {
                var pokemon = await _pokemonService.GetPokemonById(id);

                if (pokemon == null)
                {
                    return NotFound(); // Resource not found
                }
                Console.WriteLine($"the pokemon to delete is {pokemon.Id}");
              await  _pokemonService.DeletePokemon(pokemon);

                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting a Pokémon.");
            }
        }
    }
}
