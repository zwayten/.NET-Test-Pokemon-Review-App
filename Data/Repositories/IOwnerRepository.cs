using Domain.Models;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IOwnerRepository /*: IRepositoryBase<Owner>*/
    {
        Owner Add(Owner entity);
        Task<IEnumerable<Owner>> GetAll();

    }
}
