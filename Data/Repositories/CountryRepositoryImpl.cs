using Domain.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class CountryRepositoryImpl: ICountryRepository
    {
        private readonly PokemonDbContext _context;
        public CountryRepositoryImpl(PokemonDbContext context) 
        {
            _context = context;
        }

        public Country Add(Country entity)
        {
            _context.Countries.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            var countries = await _context.Countries.ToListAsync();

            return countries;
        }
    }
}
