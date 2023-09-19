using Domain.Models;
using Infrastructure.ServiceFactory;

namespace Application.Services
{

    public interface ICountryService /*: IServiceBase<Country>*/
    {
        Country AddCountry(Country entity);
        Task<IEnumerable<Country>> GetAllCountry();
    }
}
