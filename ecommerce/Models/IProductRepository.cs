using System.Collections.Generic;

namespace ecommerce.Models
{
  public interface IProductRepository
  {
    IEnumerable<Product> ProductsOfTheWeek { get; }
    IEnumerable<Product> GetProducts(string name = null, bool order = false);
    Product GetProductById(int productId);
    bool Add(Product product);
    bool Update(Product product);
    bool Delete(int productId);
  }
}