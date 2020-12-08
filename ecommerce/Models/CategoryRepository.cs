using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            return await _appDbContext.Categories.FindAsync(categoryId);
        }

        public async Task<bool> AddAsync(Category category)
        {
            await _appDbContext.Categories.AddAsync(category);
            await _appDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(Category category)
        {
            var categoryDb =
                await _appDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == category.CategoryId);

            categoryDb.CategoryName = category.CategoryName;
            _appDbContext.Update(categoryDb);
            await _appDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int categoryId)
        {
            var category = await _appDbContext.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == categoryId);

            _appDbContext.Categories.Remove(category);

            await _appDbContext.SaveChangesAsync();

            return true;
        }
    }
}