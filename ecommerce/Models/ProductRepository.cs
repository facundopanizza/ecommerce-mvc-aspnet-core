using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Models
{
  public class ProductRepository : IProductRepository
  {
    private readonly AppDbContext _appDbContext;
    public ProductRepository(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
    }

    public IEnumerable<Product> ProductsOfTheWeek
    {
      get
      {
        return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsProductOfTheWeek == true);
      }
    }

    public Product GetProductById(int productId)
    {
      return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
    }

    public bool Add(Product product)
    {
      _appDbContext.Products.Add(product);
      _appDbContext.SaveChanges();

      return true;
    }

    public bool Update(Product product)
    {
      _appDbContext.Update(product);

      _appDbContext.SaveChanges();

      return true;
    }

    public bool Delete(int productId)
    {
      var product = _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);

      if (product == null)
      {
        return false;
      }

      _appDbContext.Products.Remove(product);
      _appDbContext.SaveChanges();

      return true;
    }

    public IEnumerable<Product> GetProducts(string name = null, bool order = false)
    {
      IEnumerable<Product> products;

      if (name != null)
      {
        if (order)
        {
          products = _appDbContext.Products.Where(p => p.Name.ToLower().Contains(name.Trim().ToLower())).OrderBy(p => p.Price);
        }
        else
        {
          products = _appDbContext.Products.Where(p => p.Name.ToLower().Contains(name.Trim().ToLower())).OrderByDescending(p => p.Price);
        }
      }
      else if (order)
      {
        products = _appDbContext.Products.OrderBy(p => p.Price);
      }
      else
      {
        products = _appDbContext.Products.OrderByDescending(p => p.Price);
      }

      return products;
    }
  }
}