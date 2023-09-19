using Domain.Models;
using Infrastructure;


namespace Data.Repositories
{
    public interface ICountryRepository /*: IRepositoryBase<Country>*/
    {
        Country Add(Country entity);
        Task<IEnumerable<Country>> GetAll();
    }
}
