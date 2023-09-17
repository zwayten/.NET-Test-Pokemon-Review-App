using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IReviewRepository
    {
        Task Add(Review entity);
        Task Update(Review entity);
        Task Delete(Review entity);
        Task<Review> GetById(int id);
        Task<IEnumerable<Review>> GetAll();
    }
}
