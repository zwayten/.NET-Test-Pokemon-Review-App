using Data.Repositories;
using Domain.Models;
using Infrastructure.ServiceFactory;

namespace Application.Services
{
    public class CountryServiceImpl : /*erviceBaseImpl<Country>, */ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryServiceImpl(ICountryRepository repository)
        {
            _countryRepository = repository;
        }

        public Country AddCountry(Country entity)
        {
            var country = _countryRepository.Add(entity);
            return country;
        }

        public async Task<IEnumerable<Country>> GetAllCountry()
        {
            return await _countryRepository.GetAll();
        }
    }
}
