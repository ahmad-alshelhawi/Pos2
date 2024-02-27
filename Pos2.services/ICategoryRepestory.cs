using Pos2.entities;
using Pos2.Models;

namespace Pos2.services
{
    public interface ICategoryRepestory
    {
        Task<Category[]> getAllCategories();
        Task<Category> getById(int id);
        Task<Category> createCategory(int id, string Name, DateOnly Date);
        Task<Category> updateCategory(int id, string Name, DateOnly Date);
        Task<Category> deleteCategory(int id);
    }
}
