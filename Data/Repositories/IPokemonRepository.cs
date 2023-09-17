using Domain.Models;
using System.Linq.Expressions;

namespace Infrastructure
{
    public interface IPokemonRepository
    {
        Task Add(Pokemon entity);
        Task Update(Pokemon entity);
        Task Delete(Pokemon entity);
        Task<Pokemon> GetById(int id);
        Task<IEnumerable<Pokemon>> GetAll();
    }
}