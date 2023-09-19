using Domain.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class OwnerRepositoryImpl: IOwnerRepository
    {
        private readonly PokemonDbContext _context;
        public OwnerRepositoryImpl(PokemonDbContext context) 
        {
            _context = context;
        }

        public Owner Add(Owner entity)
        {
            try
            {
                _context.Owners.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<IEnumerable<Owner>> GetAll()
        {
            
            var owners = await _context.Owners.Include(x => x.Country).ToListAsync();

            return owners;
            
           
        }
    }
}
