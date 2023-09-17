using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ReviewRepositoryImpl : IReviewRepository
    {
        private readonly PokemonDbContext _context;

        public ReviewRepositoryImpl(PokemonDbContext context)
        {
            _context = context;
        }
        public async Task Add(Review entity)
        {
              _context.Reviews.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task Delete(Review entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
