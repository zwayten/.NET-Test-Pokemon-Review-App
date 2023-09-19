using Data.Repositories;
using Domain.Models;
using Infrastructure.ServiceFactory;

namespace Application.Services
{
    public class CountryServiceImpl : ServiceBaseImpl<Country>, ICountryService
    {
        public CountryServiceImpl(ICountryRepository repository): base(repository)
        {
            
        }
    }
}
