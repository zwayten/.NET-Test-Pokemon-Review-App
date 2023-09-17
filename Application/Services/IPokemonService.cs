using Domain.Models;


namespace Application.Services
{
    public interface IPokemonService
    {
        Task AddPokemon(Pokemon entity);
        Task UpdatePokemon(Pokemon entity);
        Task DeletePokemon(Pokemon entity);
        Task<Pokemon> GetPokemonById(int id);
        Task<IEnumerable<Pokemon>> GetAllPokemon();
    }
}
