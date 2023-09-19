using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ServiceFactory
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        TEntity Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
