using Microsoft.EntityFrameworkCore;
using Pos2.entities;
using Pos2.Models;

namespace Pos2.services
{
    public class CategoryRepestory : ICategoryRepestory
    {
        public readonly PosDbContext _db;
        public CategoryRepestory(PosDbContext db)
        {
            _db = db;
        }

        public async Task<Category[]> getAllCategories()
        {
            IQueryable<Category> query = _db.Categories;
            return await query.ToArrayAsync();
        }

        public async Task<Category> getById(int id)
        {
            IQueryable<Category> query = _db.Categories;
            query = query.Where(c => c.Id == id);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Category> createCategory(int id, string Name, DateOnly Date)
        {
            var Category = new Category { Id = id, Name = Name, Date = Date };

            _db.Add(Category);
            await _db.SaveChangesAsync();
            return Category;
        }

        public async Task<Category> updateCategory(int id, string Name, DateOnly Date)
        {
            var category = await _db.Categories.FindAsync(id);


            category.Name = Name;
            category.Date = Date;

            await _db.SaveChangesAsync();

            return category;
        }
        public async Task<Category> deleteCategory(int id)
        {
            var category = await _db.Categories.FindAsync(id);
            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
            return category;
        }

    }
}
