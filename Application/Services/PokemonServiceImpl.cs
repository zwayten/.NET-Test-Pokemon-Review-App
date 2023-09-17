using Domain.Models;
using Infrastructure;

namespace Application.Services
{
    public class PokemonServiceImpl : IPokemonService
    {
        
            private readonly IPokemonRepository _pokemonRepository;

            public PokemonServiceImpl(IPokemonRepository pokemonRepository)
            {
                _pokemonRepository = pokemonRepository;
            }

            public async Task AddPokemon(Pokemon entity)
            {
                await _pokemonRepository.Add(entity);
            }

            public async Task UpdatePokemon(Pokemon entity)
            {
                await _pokemonRepository.Update(entity);
            }

            public async Task DeletePokemon(Pokemon entity)
            {
                await _pokemonRepository.Delete(entity);
            }

            public async Task<Pokemon> GetPokemonById(int id)
            {
                return await _pokemonRepository.GetById(id);
            }

            public async Task<IEnumerable<Pokemon>> GetAllPokemon()
            {
                return await _pokemonRepository.GetAll();
            }
        }
}
