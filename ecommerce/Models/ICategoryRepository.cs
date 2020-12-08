using System.Collections.Generic;
using System.Threading.Tasks;

namespace ecommerce.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        Task<Category> GetCategoryByIdAsync(int categoryId);
        Task<bool> AddAsync(Category category);
        Task<bool> UpdateAsync(Category category);
        Task<bool> DeleteAsync(int categoryId);
    }
}