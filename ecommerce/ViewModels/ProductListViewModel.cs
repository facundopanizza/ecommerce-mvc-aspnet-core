using System.Collections.Generic;
using ecommerce.Models;

namespace ecommerce.ViewModels
{
  public class ProductListViewModel
  {
    public IEnumerable<Product> Products { get; set; }
    public string CurrentCategory { get; set; }
  }
}