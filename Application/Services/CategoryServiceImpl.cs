using Data.Repositories;
using Domain.Models;
using Infrastructure;
using Infrastructure.ServiceFactory;

namespace Application.Services
{
    public class CategoryServiceImpl : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryServiceImpl(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategory(Category entity)
        {
            await _categoryRepository.Add(entity);
        }

        public async Task DeleteCategory(Category entity)
        {
            await _categoryRepository.Delete(entity);
        }

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            return await _categoryRepository.GetAll();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.GetById(id);
        }

        public async Task UpdateCategory(Category entity)
        {
            await _categoryRepository.Update(entity);
        }
    }
}
