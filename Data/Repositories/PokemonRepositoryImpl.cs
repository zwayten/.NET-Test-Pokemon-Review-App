using Domain.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace Data.Repositories
{
    public class PokemonRepositoryImpl : IPokemonRepository
    {
        private readonly PokemonDbContext _dbContext;


        public PokemonRepositoryImpl(PokemonDbContext context)
        {
            _dbContext = context;
        }

        public async Task Add(Pokemon entity)
        {
            _dbContext.Pokemons.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Pokemon entity)
        {
            _dbContext.Pokemons.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pokemon>> GetAll()
        {
            return await _dbContext.Pokemons.ToListAsync();
        }

        public async Task<Pokemon> GetById(int id)
        {
            return await _dbContext.Pokemons.FindAsync(id);
        }

        public async Task<Pokemon> GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Pokemon entity)
        {
            _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
    }
