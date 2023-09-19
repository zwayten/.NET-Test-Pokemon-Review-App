using Domain.Models;
using Infrastructure;

namespace Data.Repositories
{
    public class CountryRepositoryImpl: RepositoryBaseImpl<Country>, ICountryRepository
    {
        public CountryRepositoryImpl(PokemonDbContext context) :base(context)
        {
            
        }
    }
}
