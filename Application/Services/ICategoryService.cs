using Domain.Models;


namespace Application.Services
{
    public interface ICategoryService 
    {
        Task AddCategory(Category entity);
        Task UpdateCategory(Category entity);
        Task DeleteCategory(Category entity);
        Task<Category> GetCategoryById(int id);
        Task<IEnumerable<Category>> GetAllCategory();
    }
}
