using Domain.Models;
using Infrastructure;

namespace Data.Repositories
{
    public interface ICategoryRepository
    {
        Task Add(Category entity);
        Task Update(Category entity);
        Task Delete(Category entity);
        Task<Category> GetById(int id);
        Task<IEnumerable<Category>> GetAll();
    }
}
