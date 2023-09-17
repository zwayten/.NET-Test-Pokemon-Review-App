using System.Linq.Expressions;

namespace Infrastructure
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int Id);
        IEnumerable<T> GetAll();

    }
}
