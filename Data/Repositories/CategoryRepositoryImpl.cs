using Domain.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CategoryRepositoryImpl : ICategoryRepository
    {
        private readonly PokemonDbContext _context;

        public CategoryRepositoryImpl(PokemonDbContext context)
        {
            _context = context;
        }
        public async Task Add(Category entity)
        {
            _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Category entity)
        {
            _context.Categories.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            try
            {

                var Categories = await _context.Categories.ToListAsync<Category>();
                //await console.out.writelineasync($"checkpoint 2 {Categories.count}");
                return Categories;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<Category> GetById(int id)
        {
            if (id == null) throw new ArgumentNullException("id");
            var foundCategory = await _context.Categories.FindAsync(id);
            return foundCategory;
        }

        public async Task Update(Category entity)
        {
            _context.Attach<Category>(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
