using System.Collections.Generic;

namespace ecommerce.Models
{
  public interface ICategoryRepository
  {
    IEnumerable<Category> AllCategories { get; }
  }
}