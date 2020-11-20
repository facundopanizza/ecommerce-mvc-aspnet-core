using System.Collections.Generic;

namespace ecommerce.Models
{
  public interface IProductRepository
  {
    IEnumerable<Product> AllProducts { get; }
    IEnumerable<Product> ProductsOfTheWeek { get; }
    Product GetProductById(int productId);
  }
}