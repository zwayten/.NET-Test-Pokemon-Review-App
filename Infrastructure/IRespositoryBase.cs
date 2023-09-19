using Domain.Models;
using System.Linq.Expressions;

namespace Infrastructure
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        Task Update(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();

    }
}
