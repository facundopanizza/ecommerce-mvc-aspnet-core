using System.Collections.Generic;

namespace ecommerce.Models
{
  public class MockCategoryRepository : ICategoryRepository
  {
    public IEnumerable<Category> AllCategories =>
      new List<Category>
      {
        new Category{CategoryId=1, CategoryName="Processor"},
        new Category{CategoryId=2, CategoryName="GPU"},
        new Category{CategoryId=3, CategoryName="RAM"}
      };
  }
}