using Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class RepositoryBaseImpl<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DbContext _context;

        public RepositoryBaseImpl(DbContext context)
        {
            _context = context;
        }
        

        public virtual TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
             _context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
             _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
